using STEPIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class TriggerEventMessage  : WorkflowOrchestratorMessage
    {

        public TriggerEventMessage()
        { }

        public Guid TriggerId { get; set; }
        public TriggerType TriggerType { get; set; }
        public Guid IFTTTAppletId { get; set; }
        public EmailTriggerMetaData EmailMetadata { get; set; }
        public FileTriggerMetatData FileMetadata { get; set; }
    }
}
