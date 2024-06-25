using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisswolf.Desktop.Models
{
    public class ArchiveResponseModel
    {
        public string id { get; set; }
        public ErrorModel error { get; set; }
        public List<string> barcodeList { get; set; }
    }

    public class ArchiveResponseDetailModel
    {
        public string ResultCode { get; set; }
        public string Message { get; set; }
        public string DocumentSerialNo { get; set; }
    }
    
    public class ErrorModel
    {
        public string code { get; set; }
        public string message { get; set; }
    }
}
