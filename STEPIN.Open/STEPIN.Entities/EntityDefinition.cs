﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class EntityDefinition
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string JSONSchema { get; set; }

        public string ETag { get; set; }

        public int Version { get; set; }
    }
}