using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ExecutionResult
    {

        public ExecutionResult()
        {

        }

        public static ExecutionResult Successful()
        {
            ExecutionResult result = new ExecutionResult();
            result.Result =ExecutionResultType.Completed;

            return result;
        }

        public static ExecutionResult Successful(string UIElementValue)
        {
            ExecutionResult result = new ExecutionResult();
            result.Result = ExecutionResultType.Completed;
            result.UIElementValue = UIElementValue;

            return result;
        }


        public ExecutionResult(double taskID, string requestID, string sessionID, string projectName, Project testSuite, ProjectStep testSuiteStep, Workflow workflow, WorkflowStep workflowStep, WorkflowActivity testCase, WorkflowActivityStep testCaseStep, Function function, FunctionStep functionStep, Keyword keyword, ObjectLookup lookedupObject, DataContext testDataRecord)
        {
            TaskID = taskID;
            RequestID = requestID;
            SessionID = sessionID;
            ProjectName = projectName;
            TestSuite = testSuite;
            TestSuiteStep = testSuiteStep;
            Workflow = workflow;
            WorkflowStep = workflowStep;
            TestCase = testCase;
            TestCaseStep = testCaseStep;
            Function = function;
            FunctionStep = functionStep;
            Keyword = keyword;
            LookedupObject = lookedupObject;
            TestDataRecord = testDataRecord;
        }

        public ExecutionResult(ExecutionTask task)
        {
            TaskID = task.TaskID;
            RequestID = task.RequestID;
            SessionID = task.SessionID;
            ProjectName = task.ProjectName;
            TestSuite = task.TestSuite;
            TestSuiteStep = task.TestSuiteStep;
            Workflow = task.Workflow;
            WorkflowStep = task.WorkflowStep;
            TestCase = task.TestCase;
            TestCaseStep = task.TestCaseStep;
            Function = task.Function;
            FunctionStep = task.FunctionStep;
            Keyword = task.Keyword;
            LookedupObject = task.LookedupObject;
            TestDataRecord = task.DataContext;
        }

        public void  SetTask(ExecutionTask task)
        {
            TaskID = task.TaskID;
            RequestID = task.RequestID;
            SessionID = task.SessionID;
            ProjectName = task.ProjectName;
            TestSuite = task.TestSuite;
            TestSuiteStep = task.TestSuiteStep;
            Workflow = task.Workflow;
            WorkflowStep = task.WorkflowStep;
            TestCase = task.TestCase;
            TestCaseStep = task.TestCaseStep;
            Function = task.Function;
            FunctionStep = task.FunctionStep;
            Keyword = task.Keyword;
            LookedupObject = task.LookedupObject;
            TestDataRecord = task.DataContext;
        }

        public double TaskID { get; set; }

        public string RequestID { get; set; }

        public string SessionID { get; set; }

        public string ProjectName { get; set; }
        public Project TestSuite { get; set; }
        public ProjectStep TestSuiteStep { get; set; }
        public Workflow Workflow { get; set; }
        public WorkflowStep WorkflowStep { get; set; }
        public WorkflowActivity TestCase { get; set; }
        public WorkflowActivityStep TestCaseStep { get; set; }
        public Function Function { get; set; }
        public FunctionStep FunctionStep { get; set; }
        public Keyword Keyword { get; set; }
        public ObjectLookup LookedupObject { get; set; }
        public DataContext TestDataRecord { get; set; }

        public string UIElementValue { get; set; }

        public DateTime StartedOn { get; set; }

        public DateTime CompletedOn { get; set; }

        public ExecutionResultType Result { get; set; }

        public string ExecutionInfo { get; set; }

        public string ErrorOnStep { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorDescription { get; set; }

        public bool HasCheckPoint { get; set; }

        public CheckpointMarker CheckPoint { get; set; }

    }

    public enum ExecutionResultType : int
    {
        NotStarted = 0,
        InProgress = 1,
        Completed = 2,
        Error = 3,
        Aborted = 4

    }
}
