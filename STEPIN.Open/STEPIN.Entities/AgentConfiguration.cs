﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class AgentConfiguration:IDoucment
    {
        public Guid _id { get; set; }

        public Guid AgentFamilyId {get;set;}

        public string AgentName { get; set; }

        public string MacAddress { get; set; }

        public bool IsProvisioned { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}
