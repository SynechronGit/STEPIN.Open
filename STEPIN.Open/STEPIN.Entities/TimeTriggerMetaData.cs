using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TimeTriggerMetaData:TriggerMetaData
    {
        public DateTime TriggerTime { get; set; }
        public int Recurrence { get; set; }
    
    }
}
