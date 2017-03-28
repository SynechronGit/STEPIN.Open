using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    /// <summary>
    /// This entity stores Mapping Between Agent Family and Target Application
    /// one Agent Family to have one or multiple target applications
    /// </summary>
    public class AgentFamilyTargetApplication
    {

        /// <summary>
        /// mongo db collection _id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// Agent Family Id
        /// </summary>
        public Guid AgentFamilyId { get; set; }

        /// <summary>
        /// Target Application Id
        /// </summary>
        public List<Guid> TargetApplicationId { get; set; }

        
    }
}
