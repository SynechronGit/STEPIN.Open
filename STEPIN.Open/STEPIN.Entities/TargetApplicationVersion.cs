using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TargetApplicationVersion : IDoucment
    {
        public Guid _id { get; set; }

        public Guid TargetApplicationId { get; set; }

        public int VersionLabel { get; set; }
        public DateTime? ReleaseDateTime { get; set; }
        public string TargetAppDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

    

