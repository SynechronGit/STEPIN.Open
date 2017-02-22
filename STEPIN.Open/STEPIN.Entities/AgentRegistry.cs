using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentRegistry
    {
        public Guid _id { get; set; }

        public Guid AgentId { get; set; }

        public Guid EnvironmentId { get; set; }

        public string MachineName { get; set; }

        public string MacId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }

    }
}
