using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ActionScript:IDoucment
    {
        public Guid _id { get; set; }

        public string ScriptName { get; set; }

        public string ScriptDescription { get; set; }
        
        public ScriptEngine ScriptEngine { get; set; } //TC or Automise enum

        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}
