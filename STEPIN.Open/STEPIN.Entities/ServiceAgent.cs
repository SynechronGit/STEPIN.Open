using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ServiceAgent
    {
        public Guid _id { get; set; }
        public string AgentName { get; set; }
        public Guid EnvironmentId { get; set; }
    }
}
