using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowActivity
    {
        public WorkflowActivity()
        {
            Steps = new List<WorkflowActivityStep>();
        }

        public string WorkflowActivityID { get; set; }

        public string Target { get; set; }

        public string Description { get; set; }

        public List<WorkflowActivityStep> Steps { get; set; }

        public bool Status { get; set; }

        public string ScreenShotURL { get; set; }

    }

 
}
