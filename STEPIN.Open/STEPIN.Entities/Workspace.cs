using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Workspace:IDocument
    {

        public Guid _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Project> Projects { get; set; }

        public List<Workflow> Workflows { get; set; }

        public List<WorkflowActivity> WorkflowActivities { get; set; }

        public List<Function> Functions { get; set; }

        public List<Keyword> Keywords { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
