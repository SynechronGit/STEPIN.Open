using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TargetApplicationVersion
    {
        public Guid _id { get; set; }

        public Guid TargetApplicationId { get; set; }

        public string VersionLabel { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public string TargetAppDescription { get; set; }

    }
}
