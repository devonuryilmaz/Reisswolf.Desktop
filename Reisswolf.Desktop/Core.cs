using Reisswolf.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisswolf.Desktop
{
    public static class Core
    {
        public static readonly Reisswolf_ArchiveEntities database = new Reisswolf_ArchiveEntities();
        public static ServiceTokenModel TokenModel { get; set; }
        public static Users ActiveUser { get; set; }
    }
}
