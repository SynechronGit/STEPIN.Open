using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
   public class LockRegistry
    {
        public Guid _id { get; set; }

        public Guid EntityId { get; set; }

        public string Key { get; set; }

        public string WhoLocked { get; set; }

        public DateTime When { get; set; }

        public DateTime Expires { get; set; }

        public Lock Lock { get; set; }

    }
}
