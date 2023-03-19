using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisswolf.Desktop.Models
{
    public class ArchiveResponseModel
    {
        public string Result1 { get; set; }
        public string Result2 { get; set; }

        public List<ArchiveResponseDetailModel> TABLE { get; set; }
    }

    public class ArchiveResponseDetailModel
    {
        public string ResultCode { get; set; }
        public string Message { get; set; }
        public string DocumentSerialNo { get; set; }
    }

}
