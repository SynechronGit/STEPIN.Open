using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ActionScriptVersion:IDoucment
    {
        public Guid _id { get; set; }
        public Guid ActionScriptId { get; set; }
        public string VersionLabel { get; set; }
        public string Description { get; set; }
        public string AzureBlobUrl { get; set; }
        public DateTime? StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public int Status { get; set; }//Draft/Published

        public string ProjectFileName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectItemName { get; set; }
        public string UnitName { get; set; }
        public string Routine { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }


    }
}
