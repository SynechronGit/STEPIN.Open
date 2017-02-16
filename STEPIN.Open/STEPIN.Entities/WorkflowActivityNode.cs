﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{  
    public class WorkflowActivityNode
    {
        public Guid _id { get; set; }
        public string text { get; set; }
        public string figure { get; set; }
        public string key { get; set; }
        public string loc { get; set; }
        public int eventType { get; set; }
        public int taskType { get; set; }
        public int gatewayType { get; set; }
        public int eventDimension { get; set; }
        public Setting settings { get; set; }
        public ActivityState ExecutationState { get; set; }
        public string category { get; set; }
    }

  
}
