﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLImporter.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Restaurant;Data Source=SROSEN-LT-5000;\" + \"Integrated Security=Fa" +
            "lse;user=\'middleware\';pwd=\'password\'")]
        public string SQLConnectionRosen {
            get {
                return ((string)(this["SQLConnectionRosen"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DATABASE\\CSCI3400011030;Initial Catalog=LIC_KIHD;Integrated Security=" +
            "false;user=\'LIC_KIHD_MW\';pwd=\'KIHD\';")]
        public string SQLConnection {
            get {
                return ((string)(this["SQLConnection"]));
            }
            set {
                this["SQLConnection"] = value;
            }
        }
    }
}
