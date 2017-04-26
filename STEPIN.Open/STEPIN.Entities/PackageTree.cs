using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    /// <summary>
    /// Stores the Dependencies of the Package/Action Script
    /// </summary>
    public class PackageTree
    {
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public List<PackageTree> PackageDependencies { get; set; }
        public PackageVersion LatestPublishedVersion { get; set; }
    }
}
