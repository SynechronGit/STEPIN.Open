using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class WorkflowRunningInstance
    {
        public Guid _id { get; set; }
        public int WorkflowId { get; set; }
        public WorkflowState WorkflowExecutionState { get; set; }
        public List<WorkflowActivityNode> WorkflowNode { get; set; }

    }

    public enum WorkflowState
    {
        InProgess,
        Failed,
        Complete
    }
}
