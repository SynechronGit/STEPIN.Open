using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkQueue:IDocument
    {
        public Guid _id { get; set; }
        public string QueueName { get; set; }
        public string QueueDescription { get; set; }
        public int DisplayOrder { get; set; }
        public int ProcessOrder { get; set; }
        public int ProcessCycle { get; set; }
        public int SLA { get; set; }
        public List<int> UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
