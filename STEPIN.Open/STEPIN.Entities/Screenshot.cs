using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace STEPIN.Entities
{
    public class Screenshot
    {
        public string AgentMachineName { get; set; }
        public string SessionID { get; set; }
        public Bitmap Image { get; set; }
        public DateTime TakenOn { get; set; }

        public string TestCaseID { get; set; }

        public string Project { get; set; }

    }
}
