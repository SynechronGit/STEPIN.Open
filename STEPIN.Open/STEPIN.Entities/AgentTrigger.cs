using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentTrigger
    {
        public List<EmailTrigger> EmailTrigger { get; set; }
        public List<FileTrigger> FileTrigger { get; set; }
        public List<TimeTrigger> TimeTrigger { get; set; }
    }
}
