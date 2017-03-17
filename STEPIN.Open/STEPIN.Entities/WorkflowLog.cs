using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowLog
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
    }
}
