using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class DomainReferenceItem:IDocument
    {
        public Guid _id { get; set; }

        public Guid DomainReferenceTypeID { get; set; }

        public string ItemCategory { get; set; }

        public string ItemKey { get; set; }

        public string ItemValue { get; set; }

        public string ItemDescription { get; set; }

        public int SerialOrder { get; set; }

        public bool IsDisabled { get; set; }

        public Nullable<Guid> GlobalUID { get; set; }

        public bool ReadOnly { get; set; }

        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
