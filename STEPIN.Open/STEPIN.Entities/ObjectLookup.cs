using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ObjectLookup
    {
        public Guid _id { get; set; }

        public string ControlType { get; set; }

        public string ObjectName { get; set; }

        public string Tag { get; set; }

        public string AccessMethod { get; set; }

        public string MasterValue { get; set; }

        public string LocatorValue { get; set; }


    }
}
