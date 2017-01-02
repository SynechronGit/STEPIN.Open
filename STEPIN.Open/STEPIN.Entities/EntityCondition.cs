using System;

namespace STEPIN.Entities
{
    public class EntityCondition
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public int SerialOrder { get; set; }

        public string Description { get; set; }

        public string ConditionExpression { get; set; }

        public string ConditionExpressionHash { get; set; }
    }
}
