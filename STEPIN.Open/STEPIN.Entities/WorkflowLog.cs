using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowLog:IDocument
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Workflow Running Instance Id
        /// </summary>
        public Guid WorkflowRunningInstanceId { get; set; }

        /// <summary>
        /// session log id
        /// </summary>
        public List<SessionLog> SessionLogs { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
