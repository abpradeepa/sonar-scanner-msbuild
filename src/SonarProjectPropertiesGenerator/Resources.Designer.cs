﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarProjectPropertiesGenerator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarProjectPropertiesGenerator.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Calling the sonar runner....
        /// </summary>
        internal static string DIAG_CallingSonarRunner {
            get {
                return ResourceManager.GetString("DIAG_CallingSonarRunner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating sonar project properties file to {0}.
        /// </summary>
        internal static string DIAG_GeneratingProjectProperties {
            get {
                return ResourceManager.GetString("DIAG_GeneratingProjectProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Located the sonar-runner: {0}.
        /// </summary>
        internal static string DIAG_LocatedSonarRunner {
            get {
                return ResourceManager.GetString("DIAG_LocatedSonarRunner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sonar runner has finished.
        /// </summary>
        internal static string DIAG_SonarRunnerCompleted {
            get {
                return ResourceManager.GetString("DIAG_SonarRunnerCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to locate the sonar-runner ({0}). Ensure that the containing directory is on the system PATH and try again..
        /// </summary>
        internal static string ERR_FailedToLocateSonarRunner {
            get {
                return ResourceManager.GetString("ERR_FailedToLocateSonarRunner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sonar runner did not complete successfully.
        /// </summary>
        internal static string ERR_SonarRunnerExecutionFailed {
            get {
                return ResourceManager.GetString("ERR_SonarRunnerExecutionFailed", resourceCulture);
            }
        }
    }
}
