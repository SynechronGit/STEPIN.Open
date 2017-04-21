using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowInstance:IDoucment
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
        /// <summary>
        /// Workflow definition - Latest version / configurred version in IFTTTT
        /// </summary>
        public WorkflowDefinition WorkflowDefinitionItem { get; set; }
        public List<WorkflowTaskStatus> TaskStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
