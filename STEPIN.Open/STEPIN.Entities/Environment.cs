﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class ConfigurationEnvironment:IDocument
    {
        public Guid _id { get; set; }

        public string WorkSpaceID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? SeniorityLevel   { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
