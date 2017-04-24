using System;

namespace STEPIN.Entities
{
    /// <summary>
    /// Use for concurrency management
    /// </summary>
    interface IDocument
    {
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
