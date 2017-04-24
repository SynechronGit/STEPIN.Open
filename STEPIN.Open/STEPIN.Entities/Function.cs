﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Function:IDocument
    {
        public Function()
        {
            Steps = new List<FunctionStep>();
        }
        public Guid _id { get; set; }

        public string WorkSpaceID { get; set; }

        public string Name { get; set; }
      
        public List<FunctionStep> Steps { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }

}
