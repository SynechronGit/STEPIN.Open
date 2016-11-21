using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class WorkflowRunningInstance
    {
        public WorkflowRunningInstance()
        {
            WFActivityState = new Dictionary<string, ActivityState>();
            Context = new Dictionary<string, WorkflowContext>();
        }

        public Guid _id { get; set; }
        public int WorkflowId { get; set; }
        public WorkflowState WorkflowExecutionState { get; set; }
        public Dictionary<string, ActivityState> WFActivityState { get; set; }

        //Property of current activity in workflow
        public string CurrentWorflowActivityNodeKey { get; set; }
        public Dictionary<string, WorkflowContext> Context { get; set; }

    }

    public class WorkflowContext
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Datatype { get; set; }
    }

    public enum WorkflowState
    {
        InProgess,
        Failed,
        Complete
    }
}
