using System;

namespace STEPIN.Entities
{
    public class ActionParameter:IDocument
    {
        /// <summary>
        /// mongo db document id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// Parameter name
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// DataType
        /// </summary>
        public string DataType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
