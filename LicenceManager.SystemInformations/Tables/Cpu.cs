using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.SystemInformations.Tables
{
   public class Cpu
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string SerialNumber { get; set; }
        public string ProcessorId { get; set; }
        public string NumberOfCores { get; set; }
    }
}
