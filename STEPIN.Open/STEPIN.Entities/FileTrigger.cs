using System;

namespace STEPIN.Entities
{
    public class FileTrigger
    {
        public Guid _id { get; set; }

        /// <summary>
        /// Trigger File Path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Trigger file filter
        /// </summary>
        public string Filter { get; set; }
    }
}
