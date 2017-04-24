using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    /// <summary>
    /// This entity stores Mapping Between ActionScript Version and Package
    /// one ActionScript Version to have one or multiple Package
    /// </summary>
    public class ActionScriptVersionPackage:IDocument
    {
        /// <summary>
        /// mongo db collection _id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// ActionScript Version Id
        /// </summary>
        public Guid ActionScriptVersionId { get; set; }

        /// <summary>
        /// Package Id
        /// </summary>
        public List<Guid> PackageId { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
