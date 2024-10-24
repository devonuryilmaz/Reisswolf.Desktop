﻿using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using net = System.Net.Http;

namespace Reisswolf.Desktop.Helpers
{

    public class HttpClient
    {
        private static readonly net.HttpClient _client;

        static HttpClient()
        {
            _client = new net.HttpClient();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<Response> PostAsync<Request, Response>(
            string url,
            Request input,
            string token = null)
        {
            return await CreateRequest<Response>(url, net.HttpMethod.Post, input, token);
        }

        public async Task<Response> PutAsync<Request, Response>(
            string url,
            Request input,
            string token = null)
        {
            return await CreateRequest<Response>(url, net.HttpMethod.Put, input, token);
        }

        public async Task<Response> GetAsync<Response>(
            string url,
            string token = null)
        {
            return await CreateRequest<Response>(url, net.HttpMethod.Get, token);
        }

        public async Task<Response> DeleteAsync<Response>(
            string url,
            string token = null)
        {
            return await CreateRequest<Response>(url, net.HttpMethod.Delete, token);
        }

        #region [ -- Private helper methods -- ]

        private async Task<Response> CreateRequest<Response>(
            string url,
            net.HttpMethod method,
            string token)
        {
            return await CreateRequestMessage(url, method, token, async msg => { return await GetResult<Response>(msg); });
        }

        private async Task<Response> CreateRequest<Response>(
            string url,
            net.HttpMethod method,
            object input,
            string token)
        {
            return await CreateRequestMessage(url, method, token, async msg =>
            {
                using (var content = new net.StringContent(JsonConvert.SerializeObject(input)))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    msg.Content = content;
                    return await GetResult<Response>(msg);
                }
            });
        }

        private async Task<Response> CreateRequestMessage<Response>(
            string url,
            net.HttpMethod method,
            string token,
            Func<net.HttpRequestMessage, Task<Response>> functor)
        {
            using (var msg = new net.HttpRequestMessage())
            {
                msg.RequestUri = new Uri(url);
                msg.Method = method;
                if (token != null)
                    msg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                return await functor(msg);
            }
        }

        private async Task<Response> GetResult<Response>(net.HttpRequestMessage msg)
        {
            using (var response = await _client.SendAsync(msg))
            {
                using (var content = response.Content)
                {
                    var responseContent = await content.ReadAsStringAsync();
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(responseContent);

                    if (typeof(IConvertible).IsAssignableFrom(typeof(Response)))
                        return (Response)Convert.ChangeType(responseContent, typeof(Response));

                    try
                    {
                        var responseContentByte = await content.ReadAsByteArrayAsync();
                        return (Response)Convert.ChangeType(responseContentByte, typeof(Response));
                    }
                    catch (Exception)
                    {
                        return JsonConvert.DeserializeObject<Response>(responseContent);
                    }
                }
            }
        }

        #endregion
    }
}