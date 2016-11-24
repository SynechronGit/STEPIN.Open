using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TargetApplication
    {
        public Guid _id { get; set; }

        public Guid WorkSpaceID { get; set; }

        public string AppName { get; set; }

        public string AppDescription { get; set; }
    }
}
