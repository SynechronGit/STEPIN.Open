using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Ensemble.NLP.Shared.Models;

namespace STEPIN.Entities
{
    public class EngineStartInfo
    {
        public string ProjectName { get; set; }

        public string RequestID { get; set; }

        public DateTime RequestedOn { get; set; }

        public string RequestedBy { get; set; }

        public string MachineName { get; set; }

        public string ReleaseLabel { get; set; }

        public string BuildLabel { get; set; }

        public string Environment { get; set; }
    }
}
