using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class PythonScriptVersion
    {
        public Guid _id { get; set; }
        public Guid ActionScriptId { get; set; }
        public string VersionLabel { get; set; }
        public int Status { get; set; }
        public string PythonScriptContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
