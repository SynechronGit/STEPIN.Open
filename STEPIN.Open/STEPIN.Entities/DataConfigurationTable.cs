using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
  public class DataConfigurationTable
    {
        public Guid _id { get; set; }     

        public string TableName { get; set; }

        public string DataSource { get; set; }

        public string Relationship { get; set; }

        public string PrimaryKey { get; set; }      

        public string DataSourceID { get; set; }

        public string EntityID { get; set; }

        public bool IsPrimary { get; set; }

        public string QueryOrSheet { get; set; }

        public string Filter { get; set; }


        public string SortBy { get; set; }
    }
}
