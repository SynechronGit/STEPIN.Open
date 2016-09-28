using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class CheckpointMarker : EventArgs
    {
        public string Name { get; set; }

        public string Project { get; set; }

        public string MachineName { get; set; }

        public string RequestID { get; set; }

        public string SessionID { get; set; }

    }
}
