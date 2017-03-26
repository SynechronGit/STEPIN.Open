using STEPIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowTaskCommandMessage
    {
        public WorkflowTaskCommandMessage()
        {
            CommandID = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public Guid CommandID { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid WorkflowInstanceId { get; set; }
        public string WorkTaskId { get; set; }
        public WorkFlowTaskType TaskType { get; set; }
        public Guid ActionScriptId { get; set; }
        public Guid AgentFamilyId { get; set; }
        public Guid EnvironmentId { get; set; }

    }
}
