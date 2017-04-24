using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class WorkFlowBAM:IDocument
    {
        public Guid _id { get; set; }

        public int SetUpCount { get; set; }

        public int PublishedCount { get; set; }

        public int RunningInstancesCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
