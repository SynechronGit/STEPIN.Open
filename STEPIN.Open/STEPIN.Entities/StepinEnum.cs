using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public enum ScriptEngine : int
    {
        [Description("TestComplete")]
        TestComplete = 1,

        [Description("Java Script")]
        JavaScript = 2,

        [Description("Step Framework")]
        StepFramework = 3       
    }

    public enum Lock {
        Acquired,
        Released
    }

    public enum ErrorLevel {        
        Checkpoint,        
        Error,
        Fatal,
        Message,
        Warning
    }

    public enum SessionStatus {
        Fail,
        Success
    }

    public enum WorkFlowTaskType : int
    {
        Unknown = 0,
        Start = 1,
        Condition = 2,
        LoopStart = 3,
        LoopEnd = 4,
        ManualTask = 5,
        Action_TestComplete = 6,
        Action_PythonScript = 7,
        Action_VBScript = 8,
        Error = 9
    }

    public enum PackageType : int
    {
        [Description("Windows Command Line Executable")]
        WindowsCommandLineExecutable = 0,

        [Description("Workflow Action")]
        WorkflowAction = 1,

        [Description("Script Extension")]
        ScriptExtension = 2,

        [Description("Test Complete Library")]
        TestCompleteLibrary = 3,

        [Description("Other")]
        Other = 4
    }

    public enum ReturnValueType : int
    {
        [Description("Returns A Collection")]
        ReturnsACollection = 0,

        [Description("Default Script Object Name")]
        DefaultScriptObjectName = 1
    }
}
