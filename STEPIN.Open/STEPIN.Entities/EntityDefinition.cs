using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class EntityDefinition:IDocument
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string JSONSchema { get; set; }

        public string ETag { get; set; }

        public int Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
