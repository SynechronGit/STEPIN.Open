using System;

namespace STEPIN.Entities
{
    public class ActionParameter
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
    }
}
