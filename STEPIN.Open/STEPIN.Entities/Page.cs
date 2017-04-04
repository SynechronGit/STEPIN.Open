using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Page {

        public Guid _id { get; set; }

        public string WorkSpaceID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ObjectLookup> ObjectLookups { get; set; }
      
        public Guid TargetApplicationVersionId { get; set; }
    }
}
