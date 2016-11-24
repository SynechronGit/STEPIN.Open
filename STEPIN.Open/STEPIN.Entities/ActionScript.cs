using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ActionScript
    {
        public Guid _id { get; set; }

        public string ScriptName { get; set; }

        public string ScriptDescription { get; set; }
        
        public int ScriptEngine { get; set; } //TC or Automise enum

    }
}
