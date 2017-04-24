using System;

namespace STEPIN.Entities
{
    public class FileStub :IDocument
    {
        /// <summary>
        /// mongo db requires Id in format _id 
        /// </summary>
        public Guid _id { get; set; }

        public string Folder { get; set; }

        public string FileName { get; set; }

        public long SizeInBytes { get; set; }

        public string Hash { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
