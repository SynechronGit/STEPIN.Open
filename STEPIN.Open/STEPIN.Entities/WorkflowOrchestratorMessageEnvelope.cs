using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STEPIN.Entities
{
    public class WorkflowOrchestratorMessageEnvelope
    {
        public TriggerEventMessage TriggerEventMessage { get; set; }
        public WorkflowTaskStatusMessage WorkflowTaskStatusMessage { get; set; }
    }
}
