using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class DataSourceConfiguration:IDoucment
    {
        public Guid _id { get; set; }

        public string DataSetName { get; set; }

        public string Discription { get; set; }

        public string WorkSpaceID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }

}
