using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class IdentityVersion:IDocument
    {
        public Guid _id { get; set; }
        public Guid IdentityId { get; set; }
        public int Version { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }       
        public string PasswordSecret { get; set; }
        public string PasswordHash { get; set; }
        public string Certificate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
