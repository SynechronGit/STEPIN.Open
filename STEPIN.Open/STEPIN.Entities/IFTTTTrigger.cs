using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class IFTTTTrigger
    {

        /// <summary>
        /// Trigger Metadata can be of any type - Email / File / Manual / Time
        /// </summary>
        public TriggerMetaData TriggerMetadata { get; set; }

        /// <summary>
        /// Can be type trigger instance - Email / File / Manual / Time
        /// </summary>
        public ITrigger TriggerInstance { get; set; } 

        public IFTTTApplet IFTTTtemplate { get; set; }
        

    }
}
