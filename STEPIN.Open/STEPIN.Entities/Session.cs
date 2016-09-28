using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Session
    {
        public Session()
        {
            Variables = new Dictionary<string, object>();
        }

        public EngineStartInfo StartInfo { get; set; }

        public string Project { get; set; }

        public string AgentMachineName { get; set; }

        public string SessionID { get; set; }

        public SessionState State { get; set; }

        public Dictionary<string, object> Variables { get; set;}

        public DateTime StartedOn { get; set; }

        public DateTime FinishedOn { get; set; }
        public string Environment { get; set; }

        public string OutputFolder { get; set; }
    }

    public enum SessionState:int
    {
        NotStarted=0,
        InProgress=1,
        SuccessfullyCompleted=2,
        ErrorCompleted=3,
        Aborted=4
    }
   

}
