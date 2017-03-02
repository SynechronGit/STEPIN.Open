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
        TimeTrigger,
        Manual
    }

    public enum AgentRunningStatus
    {
        Available,
        UnAvailable,
        Working
    }

    public enum WorkflowState
    {
        Queued,
        Executing,
        Failed,
        Completed,
        Started,
        Aborted
    }

    public enum EntityType
    {
        Agent,
        Workflow
        
    }

    public enum ActivityState
    {
        InProgess,
        Queued,
        Failed,
        Passed,
        Started,
        Aborted
    }

    public enum TaskType
    {
        Start,
        HumanAction,
        ExecuteScript,
        Condition,
        End
    }

    public enum ScriptEngine
    {
        TestComplete=1,
        Automise=2,
        PythonScript=3
    }

    public enum Lock {
        Acquired,
        Released
    }
}
