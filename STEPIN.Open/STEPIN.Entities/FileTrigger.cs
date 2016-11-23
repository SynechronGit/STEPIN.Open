using System;

namespace STEPIN.Entities
{
    public class FileTrigger
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Trigger File Path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Trigger file filter
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public string ProjectID { get; set; }

        /// <summary>
        /// Is Trigger Active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Trigger Start Date
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Trigger Expiry Date
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Trigger Status
        /// </summary>
        public Status Status { get; set; }
    }
}
