using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class Keyword:IDocument
    {
        public Guid _id { get; set; }

        public string WorkSpaceID { get; set; }

        public string Name { get; set; }
        public string KeywordType { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        //TODO: Purpose of the field not knowmn...Pradeep
        //public NameValueCollection KeywordParameters { get; set; }

    }
}
