using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class IdentityVersion
    {
        Guid _id { get; set; }
        Guid IdentityId { get; set; }
        int Version { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }       
        public string PasswordScrete { get; set; }
        public string PasswordHash { get; set; }
        public string Certificate { get; set; }
    }
}
