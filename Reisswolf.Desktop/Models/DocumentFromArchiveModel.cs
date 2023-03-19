using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisswolf.Desktop.Models
{
    public class DocumentFromArchiveModel
    {
        public DocumentFromArchiveModel()
        {
            this.TABLE = new List<DocumentArchiveModel>();
        }
        public string barcodeCourierArchive { get; set; }
        public List<DocumentArchiveModel> TABLE { get; set; }
    }

    public class DocumentArchiveModel
    {
        public string documentSerialNo { get; set; }
        public string parcelCodeArchive { get; set; }
    }
}
