using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class AgentBAM
    {
        public Guid _id { get; set; }

        public int SetUpCount { get; set; }

        public int PublishedCount { get; set; }

        public  int RunningInstancesCount{ get; set; }
    }
}
