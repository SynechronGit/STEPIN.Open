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
        public DateTime MaintenanceStartDateTime { get; set; }
        public DateTime MaintenanceEndDateTime { get; set; }
    }
}
