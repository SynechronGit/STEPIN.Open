using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Project
    {
        public Project()
        {
            Steps = new List<ProjectStep>();
        }

        public Guid _id { get; set; }

        public string ProjectID { get; set; }

        public string WorkSpaceID { get; set; }

        public string Name { get; set; }

        public string ExecutionScope { get; set; }

        public string ApplicationName { get; set; }

        public string Target { get; set; }

        public string Description { get; set; }

        public string Execute { get; set; }

        public string Engine { get; set; }

        public string LineOfBusiness { get; set; }

        public string DataSet { get; set; }

        public List<ProjectStep> Steps { get; set; }

        public int TotalTestCases { get; set; }

        public int TotalTestCasePassed { get; set; }

        public int TotalTestCaseFailed { get; set; }

        //To calculate total time taken by TestSuite to Execute
        public DateTime StartedOn { get; set; }

        //To calculate total time taken by TestSuite to Execute
        public DateTime FinishedOn { get; set; }

        public string Department { get; set; }

        public string BusinessOwner { get; set; }

        public string TechnicalOwner { get; set; }
    }


}
