using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningWorkFlowActivity:IDoucment
    {
        public Guid _id { get; set; }

        public Guid WorkFlowID { get; set; }

        public string Activity { get; set; }

        public WorkflowState Status { get; set; }

        public string Output { get; set; }

        public Guid AgentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
