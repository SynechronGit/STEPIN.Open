using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowInstance
    {

        public Guid _id { get; set; }
        public Guid WorkflowId { get; set; }
        public Guid WorkflowDefinitionId { get; set; }
        public Guid TriggerId { get; set; }

        public TriggerType TriggerType { get; set; }

        public Guid IFTTTAppletId { get; set; }

        public Guid AgentId { get; set; }
        public WorkflowState WorkflowExecutionState { get; set; }

        public string EnvironmentName { get; set; }
        public Guid EnvironmentId { get; set; }

        public DateTime StartedOn { get; set; }
        public DateTime CompletedOn { get; set; }

        public List<ConfigurationVariable> Variables { get; set; }

        //metadata
        public EmailTriggerMetaData EmailMetadata { get; set; }
        public FileTriggerMetatData FileMetadata { get; set; }

    }
}
