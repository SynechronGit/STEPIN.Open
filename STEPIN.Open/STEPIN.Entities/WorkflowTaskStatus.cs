using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowTaskStatus
    {
        public string TaskId { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime StartedOnUTC { get; set; }
        public DateTime CompletedOnUTC { get; set; }
        public Guid AssignedAgentFamiltyId { get; set; }
        public Guid AssignedAgentConfigurationId { get; set; }
        public string Output { get; set; }
        public WorkFlowTaskType TaskType { get; set; }
        public Guid ActionScriptId { get; set; }
        public TaskStatusType Status { get; set; }
    }


    public enum TaskStatusType : int
    {
        Unknown = 0,
        Created = 1,
        Queued = 2,
        Dequeued = 3,
        Executing = 4,
        Aborted = 5,
        Completed = 6,
        CompletedWithSuccess = 7,
        CompletedWithFailure = 8,
        CompletedPendingRetry = 9

    }



}
