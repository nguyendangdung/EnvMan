﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AUM.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class AUMSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AUMSettings defaultInstance = ((AUMSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AUMSettings())));
        
        public static AUMSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://env-man.sourceforge.net/")]
        public string WebPath {
            get {
                return ((string)(this["WebPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"\\\\Anastasia_Corporation\\\\\"")]
        public string LocalPath {
            get {
                return ((string)(this["LocalPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("VersionInfo.aum")]
        public string VersionFile {
            get {
                return ((string)(this["VersionFile"]));
            }
            set {
                this["VersionFile"] = value;
            }
        }
    }
}