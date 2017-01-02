using System;

namespace STEPIN.Entities
{
    public class EntityAttribute
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int OrdinalNumber { get; set; }

        public int DataType { get; set; }

        public Guid DomainReferenceTypeId { get; set; }

        public int Length { get; set; }

        public int Precision { get; set; }

        public int MinumumValue { get; set; }

        public int MaximumValue { get; set; }

        public int MinumumLength { get; set; }

        public int MaximumLength { get; set; }

        public string ValidationRegEx { get; set; }

        public bool IsRequired { get; set; }

        public bool IsReadOnly { get; set; }

        public bool IsHidden { get; set; }

        public bool IsKey { get; set; }

        public int KeyOrdinal { get; set; }

        public bool IsIndex { get; set; }

        public int IndexOrdinal { get; set; }

        public Guid DisplayFormat { get; set; }

        public string EditorControl { get; set; }
    }
}
