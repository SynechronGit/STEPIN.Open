using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowLinkData
    {
        public Guid _id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string FromPort { get; set; }
        public string ToPort { get; set; }
        public string Points { get; set; }

    }
}
