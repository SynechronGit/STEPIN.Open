using System;

namespace STEPIN.Entities
{
    public class Entity:IDoucment
    {
        public Guid _id { get; set; }

        public EntityBaseType EntityBaseType { get; set; }

        public string Name { get; set; }

        public string PluralName { get; set; }

        public string Description { get; set; }

        public string DataSourceName { get; set; }

        public string PhysicalName { get; set; }

        public int Version { get; set; }

        public EntityStatus Status { get; set; }

        public bool IsSystemEntity { get; set; }

        public bool IsReadOnly { get; set; }

        public bool IsChildOnly { get; set; }

        public bool AttributesNotDefined { get; set; }

        public string JSONSchema { get; set; }

        public string CLRType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
