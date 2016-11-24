using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TargetApplicationAgent
    {
        public Guid _id { get; set; }
        public Guid TargetApplicationId { get; set; }
        public Guid AgentId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsActive { get; set; }

        public string AgentName { get; set; }

        public string Environment { get; set; }
    }
}
