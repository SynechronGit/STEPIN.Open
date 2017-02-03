using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningAgentLog
    {
        public Guid _id { get; set; }
        public DateTime Date { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }

        public EntityType Type { get; set; }
    }
}
