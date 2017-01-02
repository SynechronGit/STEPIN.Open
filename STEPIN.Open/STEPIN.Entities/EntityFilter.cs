using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    public class EntityFilter
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FilterFunction { get; set; }

        public string FilterFunctionHash { get; set; }

        public List<string> FilterParameters { get; set; }
    }
}
