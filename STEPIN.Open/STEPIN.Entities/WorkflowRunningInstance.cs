using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class WorkflowRunningInstance
    {
        //public WorkflowRunningInstance()
        //{
        //    WFActivityState = new Dictionary<string, ActivityState>();
        //    Context = new Dictionary<string, WorkflowContext>();
        //}

        public WorkflowRunningInstance()
        {
            Activities = new List<WorkflowActivityNode>();
            ActivityLinkData = new List<WorkflowLinkData>();
        }

        public Guid _id { get; set; }
        public Guid WorkflowId { get; set; }
        public Guid WorkflowDefinitionId { get; set; }
        public Guid TriggerId { get; set; }
        
        //public Guid ProjectId { get; set; }
        public Guid AgentId { get; set; }
        public WorkflowState WorkflowExecutionState { get; set; }

        //To do: to be removed in future
        public string EnvironmentName { get; set; }
        public Guid EnvironmentId { get; set; }

        public DateTime StartedOn { get; set; }
        public DateTime CompletedOn { get; set; }

        public List<ConfigurationVariable> Variables { get; set; }

        public string BlobUrl { get; set; }

        public List<WorkflowActivityNode> Activities { get; set; }

        public List<WorkflowLinkData> ActivityLinkData { get; set; }

        //public Dictionary<string, ActivityState> WFActivityState { get; set; }

        //Property of current activity in workflow
        //public string CurrentWorflowActivityNodeKey { get; set; }
        //public Dictionary<string, WorkflowContext> Context { get; set; }

    }

    //public class WorkflowContext
    //{
    //    public string Key { get; set; }
    //    public string Value { get; set; }
    //    public string Datatype { get; set; }
    //}

  
}
