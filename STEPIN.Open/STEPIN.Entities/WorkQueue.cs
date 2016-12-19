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
        public string QueueName { get; set; }
        public string QueueDescription { get; set; }
        public int DisplayOrder { get; set; }
        public int ProcessOrder { get; set; }
        public int ProcessCycle { get; set; }
        public int SLA { get; set; }
        public List<int> UserId { get; set; }

    }
}
