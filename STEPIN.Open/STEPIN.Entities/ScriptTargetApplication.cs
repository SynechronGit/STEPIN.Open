using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    class ScriptTargetApplication
    {
        public Guid _id { get; set; }
        public Guid ActionScriptId { get; set; }
        public Guid TargetApplicationId { get; set; }

    }
}
