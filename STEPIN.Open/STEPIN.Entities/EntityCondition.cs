using System;

namespace STEPIN.Entities
{
    public class EntityCondition:IDoucment
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public int SerialOrder { get; set; }

        public string Description { get; set; }

        public string ConditionExpression { get; set; }

        public string ConditionExpressionHash { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
