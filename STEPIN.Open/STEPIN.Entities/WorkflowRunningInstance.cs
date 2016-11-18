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
        }
        public int Id { get; set; }
        public int WorkflowId { get; set; }
        public WorkflowState WorkflowExecutionState { get; set; }
        public Dictionary<string, ActivityState> WFActivityState { get; set; }

        //Property of current activity in workflow
        public string CurrentWorflowActivityNodeKey { get; set; }
        public dynamic WfInputProperty { get; set; }
        public dynamic WfActivityOutputProperty { get; set; }

    }

    public enum WorkflowState
    {
        InProgess,
        Failed,
        Complete
    }
}
