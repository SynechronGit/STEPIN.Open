using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class DataContext
    {
        public DataContext()
        {
        }

        public DataContext(DataSet operationalDataSet) 
        {
            OperationalDataSet = operationalDataSet;
        }

        public DataSet OperationalDataSet { get; set; }

        public bool IsTestSuiteStepDataDriven { get; set; }
        public string TestSuiteStepTable { get; set; }
        public DataRow  TestSuiteStepRow { get; set; }
        public string TestSuiteStepRowKey { get; set; }

        public bool IsWorkflowStepDataDriven { get; set; }
        public string WorkflowStepTable { get; set; }
        public DataRow WorkflowStepRow { get; set; }
        public string WorkflowStepRowKey { get; set; }

        public bool IsTestCaseStepDataDriven { get; set; }
        public string TestCaseStepTable { get; set; }
        public DataRow TestCaseStepRow { get; set; }
        public string TestCaseStepRowKey { get; set; }

        public string GetDebugPrint()
        {
            string printStatement = string.Empty;

            if (IsTestSuiteStepDataDriven)
                printStatement += TestSuiteStepTable  + "=" + TestSuiteStepRowKey +";" ;

            if(IsWorkflowStepDataDriven)
            printStatement += WorkflowStepTable + "=" + WorkflowStepRowKey + ";";

            if(IsTestCaseStepDataDriven)
                printStatement += TestCaseStepTable + "=" + TestCaseStepRowKey +";";

            return printStatement;
        }

    }

    public class TestDataRows : List<DataRow>
    { }

    //public class TestDataRecord : Dictionary<string, TestDataRows>
    //{
    //    public string Key { get; set; }
    //    public int RecordNumber { get; set; }
    //    public int TotalRecords { get; set; }
    //}
}
