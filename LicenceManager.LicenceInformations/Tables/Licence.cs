using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.LicenceInformations.Tables
{
   public class Licence
    {
        public Licence()
        {
            SystemInfos = new List<SystemInfo>();
            Modules = new List<Module>();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Company { get; set; }
        public List<SystemInfo> SystemInfos { get; set; }
        public List<Module> Modules { get; set; }
    }
}
