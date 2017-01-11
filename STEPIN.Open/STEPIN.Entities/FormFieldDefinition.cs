using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FormFieldDefinition
    {
        public FormFieldDefinition()
        {
            items = new List<FormFieldDefinition>();
        }

        public string key { get; set; }
        public string type { get; set; }
        public string style { get; set; }
        public string title { get; set; }
        public string onClick { get; set; }
        public string placeholder { get; set; }

        public string description { get; set; }

        public string htmlClass { get; set; }
        public List<FormFieldDefinition> items { get; set; }
    }
}
