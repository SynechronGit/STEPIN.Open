using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ConfigurationEnvironment
    {
        public Guid _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SeniorityLevel   { get; set; }

    }
}
