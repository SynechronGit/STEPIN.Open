using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{

    public class EngineEventArgs : EventArgs
    {

        public EngineEventArgs() : base()
        { }

        public EngineEventArgs(Session session, Project testSuite = null, ProjectStep step = null, Workflow workflow = null, WorkflowStep workflowStep = null, Entities.WorkflowActivity testCase = null, WorkflowActivityStep testCaseStep = null, Function function = null, FunctionStep testFunctionStep = null, Entities.Keyword keyword = null, DataContext testDataRecord = null, ExecutionResult result = null)
        {
           
            this.Session = session;
            this.TestSuite = testSuite;
            this.TestSuiteStep = TestSuiteStep;
            this.Workflow = workflow;
            this.WorkflowStep = workflowStep;
            this.TestCase = testCase;
            this.TestCaseStep = testCaseStep;
            this.Function = function;
            this.FunctionStep = testFunctionStep;
            this.Keyword = keyword;
            this.TestDataRecord = testDataRecord;
            this.Result = result;
        }

      
        public Session Session { get; set; }

        public Project TestSuite { get; set; }
        public ProjectStep TestSuiteStep { get; set; }
        public Workflow Workflow { get; set; }
        public WorkflowStep WorkflowStep { get; set; }
        public Entities.WorkflowActivity TestCase { get; set; }
        public WorkflowActivityStep TestCaseStep { get; set; }
        public Function Function { get; set; }
        public FunctionStep FunctionStep { get; set; }
        public Entities.Keyword Keyword { get; set; }
        public DataContext TestDataRecord { get; set; }
        public ExecutionResult Result { get; set; }

    }
}
