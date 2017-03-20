using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowTask
    {
        public Guid _id { get; set; }

        public Guid WorkflowId { get; set; }

        public Guid WorkflowInstanceId { get; set; }

        public Guid WorkflowTaskId { get; set; }

    }
}
