using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class MaintenanceWindow:IDoucment
    {

        public Guid _id { get; set; }
        public Guid TargetApplicationId { get; set; }
        public string MaintenanceWindowName { get; set; }
        public string MaintenanceWindowDescription { get; set; }
        public DateTime? MaintenanceStartDateTime { get; set; }
        public DateTime? MaintenanceEndDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }


    }
}
