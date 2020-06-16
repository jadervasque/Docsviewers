// Decompiled with JetBrains decompiler
// Type: DwMessages.Properties.Settings
// Assembly: DwMessages, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0254672-D66E-46CD-B2BF-6F19C7526911
// Assembly location: C:\Users\jader\OneDrive\Documentos\Visual Studio 2015\Projects\Softwares\DwMessages.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DwMessages.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized(new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=vasque.ddns-intelbras.com.br,1433;Initial Catalog=1159;Persist Security Info=True;User ID=jader;Password=SQLvasque15")]
    public string Connection1159
    {
      get
      {
        return (string) this["Connection1159"];
      }
    }
  }
}
