using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TargetApplication
    {
        public Guid _id { get; set; }

        public string ApplicationName { get; set; }

        public string ApplicationDescription { get; set; }
    }
}
