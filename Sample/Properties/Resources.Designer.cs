﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sample.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Data object.
        /// </summary>
        internal static string Data_Name {
            get {
                return ResourceManager.GetString("Data_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First value (A).
        /// </summary>
        internal static string ItemType_A {
            get {
                return ResourceManager.GetString("ItemType_A", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Second value (B).
        /// </summary>
        internal static string ItemType_B {
            get {
                return ResourceManager.GetString("ItemType_B", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Third value (C).
        /// </summary>
        internal static string ItemType_C {
            get {
                return ResourceManager.GetString("ItemType_C", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forth value (D).
        /// </summary>
        internal static string ItemType_D {
            get {
                return ResourceManager.GetString("ItemType_D", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap RedoImage {
            get {
                object obj = ResourceManager.GetObject("RedoImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Redo {0}.
        /// </summary>
        internal static string RedoMask {
            get {
                return ResourceManager.GetString("RedoMask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap UndoImage {
            get {
                object obj = ResourceManager.GetObject("UndoImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undo {0}.
        /// </summary>
        internal static string UndoMask {
            get {
                return ResourceManager.GetString("UndoMask", resourceCulture);
            }
        }
    }
}