using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    

    public class ExecutionTask 
    {
        public ExecutionTask()
        { }
        public ExecutionTask(double taskID, Project testSuite, ProjectStep step, Workflow workflow, WorkflowStep workflowStep, WorkflowActivity testCase, WorkflowActivityStep testCaseStep, Function function, FunctionStep testFunctionStep, Keyword keyword, ObjectLookup lookedupObject, DataContext testDataRecord, Session session)
        {
            TaskID = taskID;
            RequestID = session.StartInfo.RequestID;
            SessionID = session.SessionID;
            ProjectName = session.Project;
            TestSuite = testSuite;
            TestSuiteStep = step;
            Workflow = workflow;
            WorkflowStep = workflowStep;
            TestCase = testCase;
            TestCaseStep = testCaseStep;
            Function = function;
            FunctionStep = testFunctionStep;
            Keyword = keyword;
            LookedupObject = lookedupObject;
            DataContext = testDataRecord;
           // ExpressionResult = expressionResult;
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
        public DataContext DataContext { get; set; }

        public string DataContextPointer { get; set; }

        public string ExpressionResult { get; set; }

        public string DataElementValue { get; set; }

    }
}
