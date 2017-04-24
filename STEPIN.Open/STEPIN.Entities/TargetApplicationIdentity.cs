using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    /// <summary>
    /// Class for Mapping Identities with Target Application
    /// </summary>
    public class TargetApplicationIdentity : IDoucment
    {
        /// <summary>
        /// mongo db collection _id
        /// </summary>
        public Guid _id { get; set; }        

        /// <summary>
        /// Target Application Id
        /// </summary>
        public Guid TargetApplicationId { get; set; }

        /// <summary>
        /// List of Identity Id's
        /// </summary>
        public List<Guid> IdentityId { get; set; }

        #region IDocument properties
        /// <summary>
        /// Created Datetime
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Created On
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Updated username
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Updated Datetime
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        #endregion
    }
}
