using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkQueue
    {
        public Guid _id { get; set; }
        public string WorkQueueName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string ProcessOrder { get; set; }
        public string ProcessCycle { get; set; }
        public string SLA { get; set; }

    }
}
