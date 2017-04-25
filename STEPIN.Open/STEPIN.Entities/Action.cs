using System;
using System.Collections.Generic;

namespace STEPIN.Entities
{
    public class Action:IDocument
    {
        /// <summary>
        /// mongo db document id
        /// </summary>
        public Guid _id { get; set; }
        
        /// <summary>
        /// Action name
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// List of action parameters
        /// will be used in all Package Types
        /// </summary>
        public List<ActionParameter> ActionParameters { get; set; }

        #region WindowsCommandLineExecutable
        /// <summary>
        /// Executable File Name
        /// </summary>
        public string ExecutableFileName { get; set; }

        /// <summary>
        /// Arguement template
        /// </summary>
        public string ArgumentTemplate { get; set; }        

        /// <summary>
        /// Return Exit code
        /// </summary>
        public bool ReturnExitCode { get; set; }

        /// <summary>
        /// needs session xml
        /// </summary>
        public bool NeedsSessionXML { get; set; }

        /// <summary>
        /// writes log xml
        /// </summary>
        public bool WritesLogXML { get; set; }
        #endregion

        #region WorkflowAction and scriptextension
        /// <summary>
        /// DLL name
        /// </summary>
        public string DLLName { get; set; }

        /// <summary>
        /// Class type name
        /// </summary>
        public string ClassTypeName { get; set; }
        #endregion

        #region ScriptExtension
        /// <summary>
        /// Enum for Return type
        /// </summary>
        public ReturnValueType ReturnValueType { get; set; }

        /// <summary>
        /// Return as collection
        /// </summary>
        public bool ReturnAsCollection { get; set; }

        /// <summary>
        /// Default Script Object Name 
        /// Alphabet only, no spaces
        /// </summary>
        public string DefaultScriptObjectName { get; set; }
        #endregion

        #region TestCompleteLibrary

        /// <summary>
        /// Project File name
        /// </summary>
        public string ProjectFileName { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Module name
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// Unit name
        /// </summary>
        public string UnitName { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        #endregion
    }
}
