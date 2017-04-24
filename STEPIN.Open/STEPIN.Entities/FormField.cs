using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormField:IDocument
    {
        public Guid _id { get; set; }

        public Guid FormId { get; set; }

        public Guid EntityAttributeId { get; set; }

        public string Tab { get; set; }

        public string Section { get; set; }

        public int Ordinal { get; set; }

        public string EntityAttributeName { get; set; }

        public string UIControlType { get; set; }

        public string DisplayCondition { get; set; }

        public bool IsReadOnly { get; set; }

        public string UserControlType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
