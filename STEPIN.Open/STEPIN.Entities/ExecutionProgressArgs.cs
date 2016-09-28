using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ExecutionProgressArgs : EventArgs
    {
        public ExecutionProgressArgs()
        {

        }

        public ExecutionProgressArgs(string projectName, string requestID, string sessionID, string machineName, double total, double completed, double passed, double failed)
        {
            ProjectName = projectName;
            RequestID = requestID;
            SessionID = sessionID;
            MachineName = machineName;
            Total = total;
            Completed = completed;
            Passed = passed;
            Failed = failed;
        }

        public string ProjectName { get; set; }

        public string RequestID { get; set; }

        public string SessionID { get; set; }

        public string MachineName { get; set; }
        public double Total { get; set; }
        public double Completed { get; set; }

        public double Passed { get; set; }

        public double Failed { get; set; }

    }
}
