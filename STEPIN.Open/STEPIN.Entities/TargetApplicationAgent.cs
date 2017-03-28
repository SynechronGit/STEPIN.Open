using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    [Obsolete]
    //TODO - To be deleted.
    public class TargetApplicationAgent
    {
        /// <summary>
        /// mongo db collection _id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// Target Application Id
        /// </summary>
        public Guid TargetApplicationId { get; set; }

        /// <summary>
        /// Agent Family Id
        /// </summary>
        public Guid AgentFamilyId { get; set; }
        
        //Commented for Github issue #37
        //public DateTime? StartDateTime { get; set; }
        //public DateTime? EndDateTime { get; set; }
        //public bool IsActive { get; set; }
    }
}
