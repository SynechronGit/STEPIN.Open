using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    public class Package
    {
        /// <summary>
        /// mongo db document id
        /// </summary>
        public Guid _id { get; set; }
        
        /// <summary>
        /// Package name
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// Package Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Package type
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Dependency Packages
        /// </summary>
        public List<Guid> DependencyPackages { get; set; }
    }
}
