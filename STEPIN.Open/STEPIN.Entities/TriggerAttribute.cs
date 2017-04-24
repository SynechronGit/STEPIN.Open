using System;

namespace STEPIN.Entities
{
    public class TriggerAttribute:IDocument
    {
        public Guid _id { get; set; }

        public string AttributeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
