using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class PublishedActionScript
    {
        public Guid ActionScriptId { get; set; }
        public string ScriptName { get; set; }
        public string ScriptDescription { get; set; }
        public int ScriptEngine { get; set; } //TC or Python
        public string VersionLabel { get; set; }
        public string Description { get; set; }
        public string AzureBlobUrl { get; set; }
        public DateTime? StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public string PythonScriptContent { get; set; }
        public string ProjectFileName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectItemName { get; set; }
        public List<TargetApplication> TargetApplications { get; set; }
    }
}
