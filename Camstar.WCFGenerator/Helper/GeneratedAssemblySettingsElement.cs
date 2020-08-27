// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.GeneratedAssemblySettingsElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class GeneratedAssemblySettingsElement : ConfigurationElement
  {
    private const string ServerOutputDirectoryProperty = "ServerOutputDirectory";
    private const string ClientOutputDirectoryProperty = "ClientOutputDirectory";
    private const string ClientSilverlightOutputDirectoryProperty = "ClientSilverlightOutputDirectory";
    private const string ClientOutputConfigPathProperty = "ClientOutputConfigPath";

    [ConfigurationProperty("ServerOutputDirectory")]
    public string ServerOutputDirectory
    {
      get
      {
        return (string) this[nameof (ServerOutputDirectory)];
      }
      set
      {
        this[nameof (ServerOutputDirectory)] = (object) value;
      }
    }

    [ConfigurationProperty("ClientOutputDirectory")]
    public string ClientOutputDirectory
    {
      get
      {
        return (string) this[nameof (ClientOutputDirectory)];
      }
      set
      {
        this[nameof (ClientOutputDirectory)] = (object) value;
      }
    }

    [ConfigurationProperty("ClientSilverlightOutputDirectory")]
    public string ClientSilverlightOutputDirectory
    {
      get
      {
        return (string) this[nameof (ClientSilverlightOutputDirectory)];
      }
      set
      {
        this[nameof (ClientSilverlightOutputDirectory)] = (object) value;
      }
    }

    [ConfigurationProperty("ClientOutputConfigPath")]
    public string ClientOutputConfigPath
    {
      get
      {
        return (string) this[nameof (ClientOutputConfigPath)];
      }
      set
      {
        this[nameof (ClientOutputConfigPath)] = (object) value;
      }
    }
  }
}
