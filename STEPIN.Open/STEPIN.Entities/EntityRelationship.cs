using System;

namespace STEPIN.Entities
{
    public class EntityRelationship
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public Guid ChildEntityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ChildTypeName { get; set; }

        public EntityRelationType RelationshipType { get; set; }

        public bool SaveChildByReference { get; set; }

        public int MinimumItems { get; set; }

        public int MaximumItems { get; set; }
    }
}
