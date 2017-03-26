using STEPIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowTaskStatusMessage : WorkflowOrchestratorMessage
    {

        public WorkflowTaskStatusMessage()
        {
            ID = Guid.NewGuid();
            IsSuccessful = false;
        }


        public WorkflowTaskStatusMessage(WorkflowTaskCommandMessage message)
        {
            ID = Guid.NewGuid();
            OriginalCommand = message;
            IsSuccessful = false;
        }

        public Guid ID { get; set; }
        public string Output { get; set; } 
        public bool IsSuccessful { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime StartedOnUTC { get; set; }
        public DateTime CompletedOnUTC { get; set; }
        public Guid AssignedAgentConfigurationId { get; set; }
        public WorkflowTaskCommandMessage OriginalCommand { get; set; }
    }
}
