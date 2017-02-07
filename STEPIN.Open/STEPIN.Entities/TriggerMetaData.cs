using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public abstract class TriggerMetaData
    {
        public int Id { get; set; }
        public Guid AppletId { get; set; }
        public Guid EnvironmentId { get; set; }
        public Guid AgentId { get; set; }
        public DateTime CreatedDate { get; set; }
       
    }
}
