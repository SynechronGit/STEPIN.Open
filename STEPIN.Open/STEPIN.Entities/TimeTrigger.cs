using System;

namespace STEPIN.Entities
{
    public class TimeTrigger
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        public Guid WorkspaceID { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public string ProjectID { get; set; }

        /// <summary>
        /// Job Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Job Recurrence
        /// </summary>
        public JobRecurrence Recurrence { get; set; }

        /// <summary>
        /// Job Starting Type
        /// </summary>
        public JobStartOn StartingType { get; set; }

        /// <summary>
        /// Job Start On Date time
        /// </summary>
        public DateTime StartJobOn { get; set; }

        /// <summary>
        /// Job Recurrence Unit
        /// </summary>
        public JobRecurrenceUnit RecurrenceUnit { get; set; }

        /// <summary>
        /// Job recur at every Unit
        /// </summary>
        public int JobRecurEveryUnit { get; set; }

        /// <summary>
        /// Job Ending Type
        /// </summary>
        public JobEndOn EndingType { get; set; }

        /// <summary>
        /// Job End on Specific Date time
        /// </summary>
        public DateTime? EndJobOn { get; set; }

        /// <summary>
        /// Job end after number of occurrences
        /// </summary>
        public int? EndJobAtOccurrence { get; set; }

        /// <summary>
        /// Job runs infinitely
        /// </summary>
        public bool? NoJobEndDate { get; set; }

    }

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
}
