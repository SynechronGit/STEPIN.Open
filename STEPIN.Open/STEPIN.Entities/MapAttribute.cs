using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MapAttribute : Attribute
    {
        public string Source { get; set; }
        public string ValueMapper { get; set; }
    }
}
