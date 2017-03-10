using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class GridSetting
    {
        public Guid _id { get; set; }

        public string CollectionName { get; set; }

        public string JSONSchema { get; set; }
    }
}
