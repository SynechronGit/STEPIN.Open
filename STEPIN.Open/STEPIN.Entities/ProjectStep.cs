using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ProjectStep
    {
        public string ProjectID { get; set; }
        public string WorkflowID { get; set; }
        public string WorkflowDescription { get; set; }
        public string SequenceNumber { get; set; }
        public string Target { get; set; }
        public string Execute { get; set; }
        public string DDT { get; set; }
        public string DDTFilter { get; set; }
        public string DDTSortBy { get; set; }

        public string ShouldExitOnFailure { get; set; }
    }
}
