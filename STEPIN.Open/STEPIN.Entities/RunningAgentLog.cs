using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningAgentLog:IDoucment
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Entity Id can be Running Agent Id or Workflow running Instance ID
        /// </summary>
        public Guid EntityId { get; set; }
        public DateTime Date { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }

        public EntityType Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
