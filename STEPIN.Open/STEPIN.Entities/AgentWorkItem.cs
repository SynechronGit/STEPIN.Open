using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    /// <summary>
    /// Message to 
    /// </summary>
    public class AgentWorkItemMessage
    {
        public Guid WorkflowInstanceId { get; set; }
        public Guid WorkTaskId { get; set; }
        public WorkFlowTaskType TaskType { get; set; }
        public Guid ActionScriptId { get; set; }
    }
}
