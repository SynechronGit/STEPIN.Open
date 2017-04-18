using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ScriptVersion
    {
        public Guid _id { get; set; }
        public Guid ActionScriptId { get; set; }
        public string VersionLabel { get; set; }
        public int Status { get; set; }
        public string ScriptContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
