using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormSchema:IDocument
    {
        public FormSchema()
        {
            FormFields = new List<FormFieldDefinition>();
        }
        public Guid _id { get; set; }

        //public Guid FormFieldDefinitionId { get; set; }

        public Guid FormId { get; set; }
        public List<FormFieldDefinition> FormFields { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }


    }
}
