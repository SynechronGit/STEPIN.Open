using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    /// <summary>
    /// Results Constants. Configured only those columns which are necessary.
    /// There are more than 40 constanst which need to be configured.
    /// </summary>
    public class ResultsConstants
    {
        public const string TestSuiteID = "TestSuiteID";
        public const string WorkFlowId = "WorkFlowId";
        //Workflow Level Report
        public const string WorkFlowStepId = "WorkFlowStepId";
        public const string TestSuiteDesc = "TestSuiteDesc";
        public const string TestDescription = "TestDescription";
        public const string Status = "Status";

        public const string TestCaseID = "TestCaseID";
        public const string TestObjective = "TestObjective";
        public const string TestStepID = "TestStepID";

        //Detailed Execution Report
        public const string Action = "Action";
        public const string ActulaResults = "ActualResults";
        public const string ScreenShot = "ScreenShot";
        public const string TimeInSeconds = "Time(sec)";

        //Summary Report
        //General
        public const string Build = "Build";
        public const string Release = "Release";
        //Execution
        public const string ExecutionDate = "ExecutionDate";
        public const string TotalExecutionTime = "TotalExecutionTime";
        public const string StartTime = "StartTime";
        public const string EndTime = "EndTime";
        public const string TestSuiteStepSequenceNumber = "TestStepSequenceNumber";
        public const string workflowStepSequenceNumber = "TestStepSequenceNumber";
        public const string RecordType = "RecordType";
    }

    public enum RecordTypeEnum
    {
        TestSuite,
        Workflow,
        TestCase,
        Function,
        Keyword
    }
}
