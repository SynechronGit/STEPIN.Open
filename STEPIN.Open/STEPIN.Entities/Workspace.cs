using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Workspace
    {
        public List<Project> Projects { get; set; }

        public List<Workflow> Workflows { get; set; }

        public List<WorkflowActivity> WorkflowActivities { get; set; }

        public List<Function> Functions { get; set; }

        public List<Keyword> Keywords { get; set; }

    }
}
