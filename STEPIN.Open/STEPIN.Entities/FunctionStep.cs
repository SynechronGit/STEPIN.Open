using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FunctionStep
    {

        public string Function { get; set; }

        public string Name { get; set; }

        public string SequenceNumber { get; set; }

        public string Module { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Action { get; set; }
        public string UIElement { get; set; }

        public string Expression { get; set; }

        public string Assertion { get; set; }

        public string Value { get; set; }

        public string DataElement { get; set; }

        public string ShouldExitOnFailure { get; set; }

        public bool TakeScreenShot { get; set; }

        public NameValueCollection Parameters { get; set; }

    }
}
