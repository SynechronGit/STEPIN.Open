﻿using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    public class PackageVersion:IDocument
    {
        /// <summary>
        /// mongo db document id
        /// </summary>
        public Guid _id { get; set; }

        /// <summary>
        /// Package Id
        /// </summary>
        public Guid PackageId { get; set; }

        /// <summary>
        /// Package Version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Package Version Status
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Blob File SHA Hash
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Blob url
        /// </summary>
        public  string BlobUrl { get; set; }

        /// <summary>
        /// Date time of Version Published
        /// </summary>
        public DateTime DateTimeCreated { get; set; }

        /// <summary>
        /// Published by, Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Action List
        /// </summary>
        public List<Action> Actions { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
