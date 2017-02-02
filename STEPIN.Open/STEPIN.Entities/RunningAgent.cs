﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class RunningAgent
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Service Agent ID
        /// </summary>
        public Guid ServiceAgentId { get; set; } //Agent 

        public AgentRunningStatus RunningStatus { get; set; }        

        public Guid WorkflowId { get; set; }

    }
}
