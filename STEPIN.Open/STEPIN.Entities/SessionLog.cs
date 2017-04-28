using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class SessionLog:IDocument
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Session Id, kept string because Session class holds string type for SessionID property
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// AgentConfiguration Id
        /// </summary>
        public Guid AgentConfigurationId { get; set; }

        /// <summary>
        /// ActionScriptId
        /// </summary>
        public Guid ActionScriptId { get; set; }

        /// <summary>
        /// Session Status: Fail/Success
        /// </summary>
        public SessionStatus SessionStatus { get; set; }

        /// <summary>
        /// Log List
        /// </summary>
        public List<Log> Logs { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
