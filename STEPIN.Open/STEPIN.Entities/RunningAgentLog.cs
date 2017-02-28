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

        /// <summary>
        /// Entity Id can be Running Agent Id or Workflow running Instance ID
        /// </summary>
        public Guid EntityId { get; set; }
        public DateTime Date { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }

        public EntityType Type { get; set; }
    }
}
