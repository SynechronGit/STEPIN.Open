using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    //Agent Family
    public class ServiceAgent:IDoucment
    {
        public Guid _id { get; set; }

        public string AgentName { get; set; }

        public Guid EnvironmentId { get; set; }

        public bool IsActive { get; set; }

        public bool AllowAutoProvision { get; set; }

        public string LicenseId { get; set; }

        /// <summary>
        /// Added after discussion with Pradeep for issues discussed on 28/03/2016
        /// </summary>
        public bool IsSystemUnknown { get; set; }
        
        public int WorkAssignmentPriority { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
