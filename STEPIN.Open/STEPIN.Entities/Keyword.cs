using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Keyword
    {
        public Guid _id { get; set; }
        public string Name { get; set; }
        public string KeywordType { get; set; }
        public string Location { get; set; }

        //TODO: Purpose of the field not knowmn...Pradeep
        //public NameValueCollection KeywordParameters { get; set; }

    }
}
