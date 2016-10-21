using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class DataSourceConfiguration
    {
        public Guid _id { get; set; }

        public string DataSetName { get; set; }

        public string TableName { get; set; }

        public bool IsPrimary { get; set; }

        public string QueryOrSheet { get; set; }

        public string DataSource { get; set; }

        public string Relationship { get; set; }

        public string Filter { get; set; }

        public string PrimaryKey { get; set; }

        public string SortBy { get; set; }

        public string WorkSpaceID { get; set; }

    }

}
