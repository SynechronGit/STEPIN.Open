using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningWorkFlowActivity
    {
        public Guid _id { get; set; }

        public Guid WorkFlowID { get; set; }

        public string Activity { get; set; }

        public WorkflowState Status { get; set; }

        public string Output { get; set; }

        public Guid AgentId { get; set; }
    }
}
