using System;

namespace STEPIN.Entities
{
    public class TimeTrigger
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Job Name
        /// </summary>
        public string TriggerName { get; set; }

        /// <summary>
        /// Job Recurrence
        /// </summary>
        public int? Recurrence { get; set; }

        /// <summary>
        /// Job Starting Type
        /// </summary>
        public int? StartingType { get; set; }

        /// <summary>
        /// Job Start On Date time
        /// </summary>
        public DateTime? StartJobOn { get; set; }

        /// <summary>
        /// Job Recurrence Unit
        /// </summary>
        public int? RecurrenceUnit { get; set; }

        /// <summary>
        /// Job recur at every Unit
        /// </summary>
        public int? JobRecurEveryUnit { get; set; }

        /// <summary>
        /// Job Ending Type
        /// </summary>
        public int? EndingType { get; set; }

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

        /// <summary>
        /// Agent Family ID
        /// </summary>
        public Guid AgentFamilyId { get; set; }

    }

   
}
