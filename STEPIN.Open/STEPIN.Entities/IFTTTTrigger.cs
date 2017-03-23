using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class IFTTTTrigger
    {   /// <summary>
        /// Can be type trigger instance - Email / File / Manual / Time
        /// </summary>
        public Guid TriggerId { get; set; }
        public TriggerType TriggerType { get; set; }

        public Guid IFTTTAppletId { get; set; }

        //metadata
        public EmailTriggerMetaData EmailMetadata { get; set; }
        public FileTriggerMetatData FileMetadata { get; set; }

    }
}
