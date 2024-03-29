﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A1QA.Core.Csharp.White.Basics.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("A1QA.Core.Csharp.White.Basics.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : [Expected:{1}] [Actual:{2}].
        /// </summary>
        internal static string AssertBaseMsg {
            get {
                return ResourceManager.GetString("AssertBaseMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String &apos;{0}&apos; contains string &apos;{1}&apos;..
        /// </summary>
        internal static string AssertDoesNotContainFailureMessage {
            get {
                return ResourceManager.GetString("AssertDoesNotContainFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Force test fail!.
        /// </summary>
        internal static string AssertForceFailMsg {
            get {
                return ResourceManager.GetString("AssertForceFailMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assert inconclusive!.
        /// </summary>
        internal static string AssertInconclusiveMsg {
            get {
                return ResourceManager.GetString("AssertInconclusiveMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clearing any data from system Clipboard....
        /// </summary>
        internal static string ClipboardClear {
            get {
                return ResourceManager.GetString("ClipboardClear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying selected data to system Clipboard....
        /// </summary>
        internal static string ClipboardCopy {
            get {
                return ResourceManager.GetString("ClipboardCopy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving data from system Clipboard....
        /// </summary>
        internal static string ClipboardRetrieve {
            get {
                return ResourceManager.GetString("ClipboardRetrieve", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to write message to event log : {0} : {1}.
        /// </summary>
        internal static string LogReportErrorMsg {
            get {
                return ResourceManager.GetString("LogReportErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to trace message : {0} : {1}.
        /// </summary>
        internal static string LogTraceErrorMsg {
            get {
                return ResourceManager.GetString("LogTraceErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drag and Drop action!.
        /// </summary>
        internal static string MouseDragMsg {
            get {
                return ResourceManager.GetString("MouseDragMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry key does not exist!.
        /// </summary>
        internal static string RegistryInvalidRegistryKeyErrorMsg {
            get {
                return ResourceManager.GetString("RegistryInvalidRegistryKeyErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid root key!.
        /// </summary>
        internal static string RegistryInvalidRootErrorMsg {
            get {
                return ResourceManager.GetString("RegistryInvalidRootErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1|{0} Scenario: {1}|{2}.
        /// </summary>
        internal static string ReportKnownDefectMsg {
            get {
                return ResourceManager.GetString("ReportKnownDefectMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3|{0} Scenario: {1}|Failed, see Feature Execution Details.
        /// </summary>
        internal static string ReportUnknownDefectMsg {
            get {
                return ResourceManager.GetString("ReportUnknownDefectMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2|{0} Scenario: {1}|{2}.
        /// </summary>
        internal static string ReportUnrepDefectMsg {
            get {
                return ResourceManager.GetString("ReportUnrepDefectMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to take a screenshot : AutomationElement is contained inside empty rectangle.
        /// </summary>
        internal static string ScreenCaptureEmptyRectangleErrorMsg {
            get {
                return ResourceManager.GetString("ScreenCaptureEmptyRectangleErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to take screenshot : {0}.
        /// </summary>
        internal static string ScreenCaptureExceptionErrorMsg {
            get {
                return ResourceManager.GetString("ScreenCaptureExceptionErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set current culture to &apos;{0}&apos;.
        /// </summary>
        internal static string SetCultureSuccessMsg {
            get {
                return ResourceManager.GetString("SetCultureSuccessMsg", resourceCulture);
            }
        }
    }
}
