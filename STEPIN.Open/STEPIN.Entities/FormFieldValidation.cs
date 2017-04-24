using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormFieldValidation:IDocument
    {
        public Guid _id { get; set; }

        public Guid FormId { get; set; }

        public string FieldsCSV { get; set; }

        public string Name { get; set; }

        public string Expression { get; set; }

        public string ErrorMessage { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
