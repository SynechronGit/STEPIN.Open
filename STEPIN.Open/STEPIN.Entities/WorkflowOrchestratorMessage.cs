using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowOrchestratorMessage
    {
        public Guid WorkflowInstanceId { get; set; }
        public Guid WorkflowId { get; set; }  
        public Guid WorkflowDefinitionId { get; set; }

    }
}
