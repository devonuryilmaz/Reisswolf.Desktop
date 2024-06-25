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
            this.archiveDocumentList = new List<DocumentArchiveModel>();
        }
        public string archiveBagId { get; set; }
        public List<DocumentArchiveModel> archiveDocumentList { get; set; }
    }

    public class DocumentArchiveModel
    {
        public string barcodeNumber { get; set; }
        public string parcelCodeArchive { get; set; }
    }
}
