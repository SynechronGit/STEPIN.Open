using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class EntitySchema
    {
        public EntitySchema()
        {
            EntityAttributes = new List<EntityAttribute>();
        }
        public Guid _id { get; set; }
        public Guid EntityId { get; set; }

        public List<EntityAttribute> EntityAttributes  { get; set; }

        public string EntityAttributeJson { get; set; }

    }
}
