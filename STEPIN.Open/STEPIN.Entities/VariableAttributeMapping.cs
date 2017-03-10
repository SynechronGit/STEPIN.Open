using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class VariableAttributeMapping
    {
        public Guid _id { get; set; }

        public Guid IFTTTAppletId { get; set; }      

        public Guid VariableId { get; set; }

        public Guid TriggerAttributeId { get; set; }
    }
}
