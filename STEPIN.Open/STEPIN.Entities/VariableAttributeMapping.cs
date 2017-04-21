using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class VariableAttributeMapping:IDoucment
    {
        public Guid _id { get; set; }

        public Guid IFTTTAppletId { get; set; }      

        public Guid VariableId { get; set; }

        public Guid TriggerAttributeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
