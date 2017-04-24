using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentSoftware:IDocument
    {
        /// <summary>
        /// mongo db document _id
        /// </summary>
        

        public Guid _id { get; set; }

        /// <summary>
        /// Software Version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Software Url
        /// </summary>
        public string BlobUrl { get; set; }

        /// <summary>
        /// Draft=0/Published=1 status
        /// </summary>
        public Status Status { get; set; }
        public int BootstrapVersion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
