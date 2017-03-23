using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentManifest
    {
        /// <summary>
        /// Agent Family GUId
        /// </summary>                       
        public Guid AgentFamilyId { get; set; }

        /// <summary>
        /// Agent Family Name
        /// </summary>
        public string AgentFamilyName { get; set; }

        /// <summary>
        /// Agent Family License Id
        /// </summary>
        public string AgentFamilyLicenseId { get; set; }

        /// <summary>
        /// Agent Configuration Id
        /// </summary>
        public Guid AgentConfigurationId { get; set; }

        /// <summary>
        /// Agent Configuration Name
        /// </summary>
        public string AgentConfigurationName { get; set; }

        /// <summary>
        /// AgentFamily object in JSON
        /// </summary>
        public string AgentFamilyConfiguration { get; set; }

        /// <summary>
        /// AgentConfiguration object in JSON
        /// </summary>
        public string AgentConfiguration { get; set; }

        /// <summary>
        /// Latest Software Package Version
        /// </summary>
        public int SoftwarePackageVersion { get; set; }

        
    }
}
