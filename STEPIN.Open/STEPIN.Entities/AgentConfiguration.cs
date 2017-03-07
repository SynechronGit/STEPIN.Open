using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentConfiguration
    {
        public Guid _id { get; set; }

        public Guid ServiceAgentId {get;set;}

        public string AgentName { get; set; }

        public string MacAddress { get; set; }

        public bool IsProvisioned { get; set; }

    }
}
