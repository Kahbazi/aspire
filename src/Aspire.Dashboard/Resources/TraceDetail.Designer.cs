﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aspire.Dashboard.Resources {
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
    public class TraceDetail {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TraceDetail() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aspire.Dashboard.Resources.TraceDetail", typeof(TraceDetail).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back.
        /// </summary>
        public static string TraceDetailBackButtonText {
            get {
                return ResourceManager.GetString("TraceDetailBackButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Depth.
        /// </summary>
        public static string TraceDetailDepthHeader {
            get {
                return ResourceManager.GetString("TraceDetailDepthHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duration.
        /// </summary>
        public static string TraceDetailDurationHeader {
            get {
                return ResourceManager.GetString("TraceDetailDurationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Traces.
        /// </summary>
        public static string TraceDetailPageTitle {
            get {
                return ResourceManager.GetString("TraceDetailPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resources.
        /// </summary>
        public static string TraceDetailResourcesHeader {
            get {
                return ResourceManager.GetString("TraceDetailResourcesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Spans.
        /// </summary>
        public static string TraceDetailTotalSpansHeader {
            get {
                return ResourceManager.GetString("TraceDetailTotalSpansHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trace &quot;{0}&quot; not found.
        /// </summary>
        public static string TraceDetailTraceNotFound {
            get {
                return ResourceManager.GetString("TraceDetailTraceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trace Detail.
        /// </summary>
        public static string TraceDetailTraceStartHeader {
            get {
                return ResourceManager.GetString("TraceDetailTraceStartHeader", resourceCulture);
            }
        }
    }
}
