using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class EmailTriggerMetaData: TriggerMetaData
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        
    }
}
