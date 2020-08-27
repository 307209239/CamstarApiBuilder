// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.GeneratorSection
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class GeneratorSection : ConfigurationSection
  {
    private const string ServicesProperty = "Services";
    private const string LightServicesProperty = "LightServices";
    private const string ForAllServicesProperty = "AllServices";
    private const string ServicesSettingsProperty = "ServicesSettings";
    private const string GeneratedAssemblySettingsProperty = "GeneratedAssemblySettings";
    private const string ConnectionSettingsProperty = "ConnectionSettings";

    [ConfigurationProperty("Services")]
    public ServiceSettingsElement RootService
    {
      get
      {
        return (ServiceSettingsElement) this["Services"];
      }
      set
      {
        this["Services"] = (object) value;
      }
    }

    [ConfigurationProperty("LightServices")]
    public ServiceSettingsElement LightRootService
    {
      get
      {
        return (ServiceSettingsElement) this["LightServices"];
      }
      set
      {
        this["LightServices"] = (object) value;
      }
    }

    [ConfigurationProperty("AllServices")]
    public ServiceSettingsElement ForAllRootService
    {
      get
      {
        return (ServiceSettingsElement) this["AllServices"];
      }
      set
      {
        this["AllServices"] = (object) value;
      }
    }

    [ConfigurationProperty("ServicesSettings")]
    public ServicesSettingsElement ServicesSettings
    {
      get
      {
        return (ServicesSettingsElement) this[nameof (ServicesSettings)];
      }
      set
      {
        this[nameof (ServicesSettings)] = (object) value;
      }
    }

    [ConfigurationProperty("GeneratedAssemblySettings")]
    public GeneratedAssemblySettingsElement GeneratedAssemblySettings
    {
      get
      {
        return (GeneratedAssemblySettingsElement) this[nameof (GeneratedAssemblySettings)];
      }
      set
      {
        this[nameof (GeneratedAssemblySettings)] = (object) value;
      }
    }

    [ConfigurationProperty("ConnectionSettings")]
    public ConnectionSettingsElement ConnectionSettings
    {
      get
      {
        return (ConnectionSettingsElement) this[nameof (ConnectionSettings)];
      }
      set
      {
        this[nameof (ConnectionSettings)] = (object) value;
      }
    }
  }
}
