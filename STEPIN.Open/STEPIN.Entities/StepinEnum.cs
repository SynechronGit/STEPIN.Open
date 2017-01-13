using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    /// <summary>
    /// Job recurrence type
    /// </summary>
    public enum JobRecurrence
    {
        OneTimeJob,
        RecurringJob
    };

    /// <summary>
    /// Job start on type
    /// </summary>
    public enum JobStartOn
    {
        StartNow,
        StartAtSpecificTime
    };

    /// <summary>
    /// Job recurrence unit type
    /// </summary>
    public enum JobRecurrenceUnit
    {
        Minutes,
        Hours,
        Days,
        Weeks,
        Months
    };

    /// <summary>
    /// Job end on Type
    /// </summary>
    public enum JobEndOn
    {
        EndOnSpecificTime,
        EndAfterOccurrenceCount,
        NoEndDate
    };

    public enum Status
    {
        Draft,
        Published
    };

    public enum EntityBaseType {
        Custom,
        System,
        Database
    };

    public enum EntityStatus {
        Unknown,
        Draft,
        Published,
        Retired
    };

    public enum EntityRelationType {
        Unknown,
        MasterDetail,
        Lookup
    };

    /// <summary>
    /// Trigger Types
    /// </summary>
    public enum TriggerType {
        FileTrigger,
        EmailTrigger,
        TimeTrigger
    }
}
