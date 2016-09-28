using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowActivityStep
    {
        public string WorkflowActivityID { get; set; }

        public string Target { get; set; }

        public string WorkflowActivityStepID { get; set; }

        public string SequenceNumber { get; set; }

        public string Module { get; set; }

        public string Description { get; set; }

        public string Action { get; set; }

        public string Function { get; set; }

        public string DDT { get; set; }

        public string DDTFilter { get; set; }

        public string DDTSortBy { get; set; }

        public string ShouldExitOnFailure { get; set; }
    }
}
