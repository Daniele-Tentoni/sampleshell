﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleShell.Resources.Strings.Login {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LoginStrings {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LoginStrings() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("SampleShell.Resources.Strings.Login.LoginStrings", typeof(LoginStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string FingerprintTitle {
            get {
                return ResourceManager.GetString("FingerprintTitle", resourceCulture);
            }
        }
        
        public static string FingerprintText {
            get {
                return ResourceManager.GetString("FingerprintText", resourceCulture);
            }
        }
        
        public static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        public static string PageRoute {
            get {
                return ResourceManager.GetString("PageRoute", resourceCulture);
            }
        }
        
        public static string AuthenticationTitle {
            get {
                return ResourceManager.GetString("AuthenticationTitle", resourceCulture);
            }
        }
        
        public static string AuthenticationSuccessText {
            get {
                return ResourceManager.GetString("AuthenticationSuccessText", resourceCulture);
            }
        }
        
        public static string AuthenticationFailureText {
            get {
                return ResourceManager.GetString("AuthenticationFailureText", resourceCulture);
            }
        }
        
        public static string AuthenticationButton {
            get {
                return ResourceManager.GetString("AuthenticationButton", resourceCulture);
            }
        }
    }
}
