using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class DomainReferenceType
    {
        public Guid _id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Schema { get; set; }

        public string SchemaVersion { get; set; }

        public string ItemValueDataType { get; set; }

        public Guid GlobalUID { get; set; }

        public bool ReadOnly { get; set; }

        public bool IsDeleted { get; set; }

        public List<DomainReferenceItem> DomainReferenceItems { get; set; }
    }
}
