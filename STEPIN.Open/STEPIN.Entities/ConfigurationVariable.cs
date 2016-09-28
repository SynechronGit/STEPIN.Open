using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ConfigurationVariable
    {
        public string Name { get; set; }
        public string Project { get; set; }

        public bool IsOverride { get; set; }

        public string VariableType { get; set; }

        public string ValueString { get; set; }

        public object ValueObject { get; set; }

        public string Description { get; set; }
    }
}
