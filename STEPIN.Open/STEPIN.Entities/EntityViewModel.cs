using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    public class EntityViewModel
    {
        public Entity Entity { get; set; }

        public List<EntityAttribute> EntityAttribute { get; set; }

        public List<EntityCalculatedAttribute> EntityCalculatedAttribute { get; set; }

        public List<EntityCondition> EntityCondition { get; set; }

        public List<EntityFilter> EntityFilter { get; set; }

        public List<EntityRelationship> EntityRelationship { get; set; }
    }
}
