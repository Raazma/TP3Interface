﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordKeeper.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point BackColorFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["BackColorFormLocation"]));
            }
            set {
                this["BackColorFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection Colors {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Colors"]));
            }
            set {
                this["Colors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>0,0,255</string>
  <string>255,153,0</string>
  <string>128,0,128</string>
  <string>230, 248, 243</string>
  <string>255,0,0</string>
  <string>218,165,32</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Event_Type_Colors {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Event_Type_Colors"]));
            }
            set {
                this["Event_Type_Colors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color DayColor {
            get {
                return ((global::System.Drawing.Color)(this["DayColor"]));
            }
            set {
                this["DayColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color HourColor {
            get {
                return ((global::System.Drawing.Color)(this["HourColor"]));
            }
            set {
                this["HourColor"] = value;
            }
        }
    }
}
