using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowActivityNode
    {
        public Guid _id { get; set; }
        public string category { get; set; }
        public string Text { get; set; }
        public string Key { get; set; }
        public string Location { get; set; }
        public NodeSetting Setting { get; set; }
        public ActivityState ExecutationState { get; set; }
    }

    public class NodeSetting
    {
        public Guid _id { get; set; }
        public string TestScript { get; set; }
        public TestTool TestingTool { get; set; }
    }

    public enum ActivityState
    {
        InProgess,
        Failed,
        Passed
    }
    public enum TestTool
    {
        Selenium,
        Autocomplete
    }
}
