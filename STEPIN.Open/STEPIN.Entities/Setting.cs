using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Setting
    {
        public Guid _id { get; set; }
     
        public ScriptDetails scriptName { get; set; }

        public HumanAction selectedhumanaction { get; set; }
    }
}
