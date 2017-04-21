using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FileSystemStub:IDoucment
    {
        public FileSystemStub()
        {
            Files = new List<FileStub>();
        }

        /// <summary>
        /// mongo db collection id
        /// </summary>
        public Guid _id { get; set; }

        public Guid TriggerID { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public List<FileStub> Files { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
