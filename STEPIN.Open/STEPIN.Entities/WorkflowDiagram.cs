using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sytorio.Agent.WorkflowOrchestrator.Model
{
    public class WorkflowDiagram
    {
        public string @class { get; set; }
        public ModelData modelData { get; set; }
        public List<NodeDataArray> nodeDataArray { get; set; }
        public List<LinkDataArray> linkDataArray { get; set; }
        public bool copiesArrays { get; set; }
        public bool copiesArrayObjects { get; set; }
        public string linkFromPortIdProperty { get; set; }
        public string linkToPortIdProperty { get; set; }
    }

    public class ModelData
    {
        public string position { get; set; }
    }

    public class ScriptTask
    {
        public string ScriptDescription { get; set; }
        public int ScriptEngine { get; set; }
        public string ScriptName { get; set; }
        public string id { get; set; }
    }

    public class HumanTask
    {
        public int id { get; set; }
        public string value { get; set; }
    }

    public class HumanTaskWorkQueue
    {
        public string id { get; set; }
        public string QueueDescription { get; set; }
        public int DisplayOrder { get; set; }
        public string QueueName { get; set; }
    }

    public class Settings
    {
        public ScriptTask scriptName { get; set; }
        public HumanTask selectedhumanaction { get; set; }
        public string selectedTaskAction { get; set; }
        public HumanTaskWorkQueue selectedworkQueue { get; set; }
    }

    public class NodeDataArray
    {
        public int key { get; set; }
        public string category { get; set; }
        public string text { get; set; }
        public int eventType { get; set; }
        public int eventDimension { get; set; }
        public string item { get; set; }
        public string loc { get; set; }
        public int? taskType { get; set; }
        public bool? isSequential { get; set; }
        public Settings settings { get; set; }
        public int? gatewayType { get; set; }
        public object group { get; set; }
        public List<object> boundaryEventArray { get; set; }
        public object isGroup { get; set; }
        public string color { get; set; }
        public string size { get; set; }
    }


    public class LinkDataArray
    {
        public int from { get; set; }
        public int to { get; set; }
        public string fromPort { get; set; }
        public string toPort { get; set; }
        public List<double> points { get; set; }
        public bool? visible { get; set; }
        public string text { get; set; }
        public string category { get; set; }
        public bool? isDefault { get; set; }
    }

   
   


}
