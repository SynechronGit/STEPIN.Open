using System;

namespace STEPIN.Entities
{
    public class EntityCalculatedAttribute:IDocument
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int DataType { get; set; }

        public int SerialOrder { get; set; }

        public bool AutoCalculate { get; set; }

        public string CalculationExpression { get; set; }

        public string CalculationExpressionHash { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
