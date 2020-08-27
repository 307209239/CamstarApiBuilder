// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ConnectionSettingsElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class ConnectionSettingsElement : ConfigurationElement
  {
    private const string IsGetFromRegistryProperty = "IsGetFromRegistry";
    private const string DefaultServerConnectionStringProperty = "DefaultServerConnectionString";
    private const string DatabaseConnectionStringProperty = "DatabaseConnectionString";
    private const string ConnectionStringProperty = "ConnectionStrings";

    [ConfigurationProperty("IsGetFromRegistry")]
    public bool IsGetFromRegistry
    {
      get
      {
        return (bool) this[nameof (IsGetFromRegistry)];
      }
      set
      {
        this[nameof (IsGetFromRegistry)] = (object) value;
      }
    }

    [ConfigurationProperty("DefaultServerConnectionString")]
    public string DefaultServerConnectionString
    {
      get
      {
        return (string) this[nameof (DefaultServerConnectionString)];
      }
      set
      {
        this[nameof (DefaultServerConnectionString)] = (object) value;
      }
    }

    [ConfigurationProperty("DatabaseConnectionString")]
    public string DatabaseConnectionString
    {
      get
      {
        return (string) this[nameof (DatabaseConnectionString)];
      }
      set
      {
        this[nameof (DatabaseConnectionString)] = (object) value;
      }
    }

    [ConfigurationProperty("ConnectionStrings")]
    public ConnectionStringElementCollection ConnectionStrings
    {
      get
      {
        return (ConnectionStringElementCollection) this[nameof (ConnectionStrings)];
      }
      set
      {
        this[nameof (ConnectionStrings)] = (object) value;
      }
    }
  }
}
