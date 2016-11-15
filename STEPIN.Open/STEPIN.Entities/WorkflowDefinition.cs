using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    /// <summary>
    /// Describes the diagram reprentation of the workflow entity
    /// </summary>
    public class WorkflowDefinition
    {
        public int _id { get; set; }
        public int WorkflowId { get; set; }
        public string Definition { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        //stores the workflow definition version name
        public string Version { get; set; }
    }
}
