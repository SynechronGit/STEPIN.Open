using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ExecutionStatus
    {

        // Mongo Object GUID
        public string RequestID { get; set; }


        // Queued > Started > In-Progress > Completed
        public string Status { get; set; }

        // Success , Failure , Abandon 
        public string ExecutionResult { get; set; }

        // Story Book Name
        public string ProjectName { get; set; }

        public DateTime RequestedOn { get; set; }

        public string RequestedBy { get; set; }
        
        public string ReleaseLabel { get; set; }

        public string BuildLabel { get; set; }
    }
}
