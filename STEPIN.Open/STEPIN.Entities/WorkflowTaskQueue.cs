using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class WorkflowTaskQueue
    {
        public Guid _id { get; set; }
        public Guid WorkflowId { get; set; }
        public Guid WorkflowDefinitionId { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string Key { get; set; }
        public string Location { get; set; }
        public string Item { get; set; }
        public int EventType { get; set; }
        public int EventDimension { get; set; }
        public ScriptDetails SelectedScript { get; set; }
        public HumanAction SelectedHumanAction { get; set; }

        /// <summary>
        ///ExecutationState: InProgess|Queued|Failed,|Passed
        /// </summary>
        public ActivityState ExecutationState { get; set; }

        /// <summary>
        /// ActivityType: HumanAction|ExecuteScript|Start|End
        /// </summary>
        public TaskType ActivityType { get; set; }
        public List<ConfigurationVariable> Variables { get; set; }

    }
}
