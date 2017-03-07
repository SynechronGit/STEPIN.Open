using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentSoftware
    {
        /// <summary>
        /// mongo db document _id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// Software Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Software Url
        /// </summary>
        public string BlobUrl { get; set; }

        /// <summary>
        /// Draft=0/Published=1 status
        /// </summary>
        public Status Status { get; set; }
    }
}
