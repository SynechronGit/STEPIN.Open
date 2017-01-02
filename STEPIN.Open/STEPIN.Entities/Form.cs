using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Form
    {
        public Guid _id { get; set; }

        public Guid _EntityTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Version { get; set; }

        public bool IsReadOnly { get; set; }

        public string Canvas { get; set; }

        public string FormJSONHash { get; set; }

        public string FormJSON { get; set; }

        public string Status { get; set; }

        public string HTMLTempalte { get; set; }       

        public List<string> Tabs { get; set; }

        public List<string> Sections { get; set; }

        public List<FormField> Fields { get; set; }

        public List<FormFieldValidation> Validations { get; set; }
    }
}
