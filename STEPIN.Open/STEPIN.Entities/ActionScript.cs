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

        public string ActionScriptName { get; set; }

        public string ActionScriptDescription { get; set; }
        
        public int ActionScriptEngine { get; set; } //TC or Automise
    }
}
