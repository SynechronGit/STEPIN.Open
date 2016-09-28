using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Function
    {
        public Function()
        {
            Steps = new List<FunctionStep>();
        }
        public string Name { get; set; }
      
        public List<FunctionStep> Steps { get; set; }

    }

}
