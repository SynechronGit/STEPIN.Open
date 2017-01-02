using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormField
    {
        public Guid _id { get; set; }

        public Guid _FormId { get; set; }

        public string Tab { get; set; }

        public string Section { get; set; }

        public int Ordinal { get; set; }

        public string EntityTypeAttributeName { get; set; }

        public string UIControlType { get; set; }

        public string DisplayCondition { get; set; }

        public bool IsReadOnly { get; set; }

        public string UserControlType { get; set; }

        public int EntityTypeAttributeID { get; set; }
    }
}
