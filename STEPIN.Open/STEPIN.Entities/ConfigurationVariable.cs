using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ConfigurationVariable
    {
        public Guid _id { get; set; }

        public string WorkSpaceID { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public string Project { get; set; }

        public bool IsCollection { get; set; }

        public string VariableType { get; set; }

        public string ValueString { get; set; }

        public object ValueObject { get; set; }

        public string Description { get; set; }
    }
}
