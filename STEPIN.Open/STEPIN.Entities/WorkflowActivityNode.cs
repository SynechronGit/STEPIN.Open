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
        public string text { get; set; }
        public string figure { get; set; }
        public string key { get; set; }
        public string loc { get; set; }
        public int eventType { get; set; }
        public int eventDimension { get; set; }
        public Setting settings { get; set; }
        public ActivityState ExecutationState { get; set; }
        public string category { get; set; }
    }

    public class TestToolName
    {
        public Guid _id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        //public string hashKey { get; set; }
        //public string mdSelectId { get; set; }
    }

    public class Setting
    {
        public Guid _id { get; set; }
        public string entityname { get; set; }
        public string version { get; set; }
        public TestToolName testtoolname { get; set; }

    }
    
    public enum ActivityState
    {
        InProgess,
        Failed,
        Passed
    }
}
