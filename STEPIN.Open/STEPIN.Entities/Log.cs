using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEPIN.Entities
{
    public class Log
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Log UTC Date Time
        /// </summary>
        public DateTime LogDateTime { get; set; }

        /// <summary>
        /// Log Error Level
        /// </summary>
        public ErrorLevel ErrorLevel { get; set; }

        /// <summary>
        /// Log Message type
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// Log message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error Details
        /// </summary>
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Image File name
        /// </summary>
        public string ImageFileName { get; set; }

        /// <summary>
        /// To Do : verify for Log description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WorkflowRunning Instance Id
        /// </summary>
        public Guid WorkflowRunningInstanceId { get; set; }

        /// <summary>
        /// Session Log Id
        /// </summary>
        public Guid SessionLogId { get; set; }
    }
}
