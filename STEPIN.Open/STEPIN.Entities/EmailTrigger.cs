using System;

namespace STEPIN.Entities
{
    public class EmailTrigger
    {
        public Guid _id { get; set; }

        /// <summary>
        /// WorkspaceID
        /// </summary>
        public Guid WorkspaceID { get; set; }

        /// <summary>
        /// Imap/Pop Incoming Server Name 
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Email Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Email Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Server Port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Is SSL to be used
        /// </summary>
        public bool IsSSL { get; set; }

        /// <summary>
        /// Secure
        /// </summary>
        public bool Secure { get; set; }        

        /// <summary>
        /// Skip SSL Validation
        /// </summary>
        public bool SkipSSLValidation { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public string ProjectID { get; set; }

        /// <summary>
        /// Is Trigger Active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Trigger Start Date
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Trigger Expiry Date
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Trigger status
        /// </summary>
        public Status Status { get; set; }
    }

 

}
