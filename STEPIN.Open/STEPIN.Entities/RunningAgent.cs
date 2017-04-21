using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningAgent:IDoucment
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Service Agent ID
        /// </summary>
        public Guid ServiceAgentId { get; set; } //Agent 

        public AgentRunningStatus RunningStatus { get; set; }        

        public Guid WorkflowId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
