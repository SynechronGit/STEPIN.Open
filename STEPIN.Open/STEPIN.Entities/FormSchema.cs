using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormSchema
    {
        public FormSchema()
        {
            FormFields = new List<FormFieldDefinition>();
        }
        public Guid _id { get; set; }

        //public Guid FormFieldDefinitionId { get; set; }

        public Guid FormId { get; set; }
        public List<FormFieldDefinition> FormFields { get; set; }
        
        
    }
}
