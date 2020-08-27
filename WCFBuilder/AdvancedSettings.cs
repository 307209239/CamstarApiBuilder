// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.AdvancedSettings
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

namespace Camstar.WCF.Builder
{
  public class AdvancedSettings
  {
    private List<ConnectionStringItem> mConnectionStrings = new List<ConnectionStringItem>();
    private string _ServerOutputDirectory = string.Empty;
    private string _ClientOutputDirectory = string.Empty;
    private string _ClientSilverlightOutputDirectory = string.Empty;
    private string _ClientOutputConfigPath = string.Empty;
    private string _DatabaseConnectionString = string.Empty;
    private string _ServerConnectionString = string.Empty;
    private string _Address = string.Empty;
    private string _LogPath = string.Empty;
    private string _LogNaming = string.Empty;
    private bool _UseSSL;
    private bool _ProcessTxnGUID;
    private bool _LogXmlDocument;
    private bool _IsGenerateAll;
    private bool _IsGenerateSilverlight;
    private bool _IsGetFromRegistry;
    private GeneratorSettings _Settings;

    [Category("Paths")]
    [Description("Output directory for server assemblies.")]
    public string ServerOutputDirectory
    {
      get
      {
        return this._ServerOutputDirectory;
      }
      set
      {
        this._ServerOutputDirectory = value;
      }
    }

    [Category("Paths")]
    [Description("Output directory for client assemblies.")]
    public string ClientOutputDirectory
    {
      get
      {
        return this._ClientOutputDirectory;
      }
      set
      {
        this._ClientOutputDirectory = value;
      }
    }

    [Category("Paths")]
    [Description("Output directory for silverlight client assemblies.")]
    public string ClientSilverlightOutputDirectory
    {
      get
      {
        return this._ClientSilverlightOutputDirectory;
      }
      set
      {
        this._ClientSilverlightOutputDirectory = value;
      }
    }

    [Category("Paths")]
    [Description("Output directory for client App.config file.")]
    public string ClientOutputConfigPath
    {
      get
      {
        return this._ClientOutputConfigPath;
      }
      set
      {
        this._ClientOutputConfigPath = value;
      }
    }

    [Category("Connections")]
    [Description("Meta-Database Connection string.")]
    public string DatabaseConnectionString
    {
      get
      {
        return this._DatabaseConnectionString;
      }
      set
      {
        this._DatabaseConnectionString = value;
      }
    }

    [Category("Services")]
    [Description("Generate all services.")]
    public bool IsGenerateAll
    {
      get
      {
        return this._IsGenerateAll;
      }
      set
      {
        this._IsGenerateAll = value;
      }
    }

    [Category("Services")]
    [Description("Generate Silverlight services.")]
    public bool IsGenerateSilverlight
    {
      get
      {
        return this._IsGenerateSilverlight;
      }
      set
      {
        this._IsGenerateSilverlight = value;
      }
    }

    [Category("Services")]
    [Description("Services Address.")]
    public string Address
    {
      get
      {
        return this._Address;
      }
      set
      {
        this._Address = value;
      }
    }

    [Category("Connections")]
    [Description("Connection String is in the registry.")]
    public bool IsGetFromRegistry
    {
      get
      {
        return this._IsGetFromRegistry;
      }
      set
      {
        this._IsGetFromRegistry = value;
      }
    }

    [Category("Services")]
    [Description("Log Path.")]
    public string LogPath
    {
      get
      {
        return this._LogPath;
      }
      set
      {
        this._LogPath = value;
      }
    }

    [Category("Services")]
    [Description("Log Naming.")]
    public string LogNaming
    {
      get
      {
        return this._LogNaming;
      }
      set
      {
        this._LogNaming = value;
      }
    }

    [Category("Services")]
    [Description("Logging.")]
    public bool LogXmlDocument
    {
      get
      {
        return this._LogXmlDocument;
      }
      set
      {
        this._LogXmlDocument = value;
      }
    }

    [Category("Services")]
    [Description("Process Txn GUID.")]
    public bool ProcessTxnGUID
    {
      get
      {
        return this._ProcessTxnGUID;
      }
      set
      {
        this._ProcessTxnGUID = value;
      }
    }

    [Category("Services")]
    [Description("Default Server Connection string.")]
    public string ServerConnectionString
    {
      get
      {
        return this._ServerConnectionString;
      }
      set
      {
        this._ServerConnectionString = value;
      }
    }

    [Category("Services")]
    [Description("Use SSL attribute.")]
    public bool UseSSL
    {
      get
      {
        return this._UseSSL;
      }
      set
      {
        this._UseSSL = value;
      }
    }

    [Category("Services")]
    [Description("List of Connection Strings.")]
    public List<ConnectionStringItem> ConnectionStrings
    {
      get
      {
        return this.mConnectionStrings;
      }
      set
      {
        this.mConnectionStrings = value;
      }
    }

    public AdvancedSettings(GeneratorSettings settings)
    {
      this._Settings = settings;
      this._Address = this._Settings.Address;
      this._ServerOutputDirectory = this._Settings.ServerOutputDirectory;
      this._ClientOutputDirectory = this._Settings.ClientOutputDirectory;
      this._ClientSilverlightOutputDirectory = this._Settings.ClientSilverlightOutputDirectory;
      this._ClientOutputConfigPath = this._Settings.ClientOutputConfigPath;
      this._DatabaseConnectionString = this._Settings.DatabaseConnectionString;
      this._ServerConnectionString = this._Settings.DefaultServerConnectionString;
      this._UseSSL = this._Settings.UseSSL;
      this._IsGenerateAll = this._Settings.IsGenerateAll;
      this._IsGenerateSilverlight = this._Settings.IsGenerateSilverlight;
      this._IsGetFromRegistry = this._Settings.IsGetFromRegistry;
      this._ProcessTxnGUID = this._Settings.ProcessTxnGUID;
      this._LogXmlDocument = this._Settings.LogXmlDocument;
      this._LogPath = this._Settings.LogPath;
      this._LogNaming = this._Settings.LogNaming;
      foreach (ConnectionStringElement connectionString in (ConfigurationElementCollection) this._Settings.ConnectionStrings)
        this.mConnectionStrings.Add(new ConnectionStringItem(connectionString.Name, connectionString.Value));
    }

    public void Save()
    {
      this._Settings.Address = this._Address;
      this._Settings.ServerOutputDirectory = this._ServerOutputDirectory;
      this._Settings.ClientOutputDirectory = this._ClientOutputDirectory;
      this._Settings.ClientSilverlightOutputDirectory = this._ClientSilverlightOutputDirectory;
      this._Settings.ClientOutputConfigPath = this._ClientOutputConfigPath;
      this._Settings.DatabaseConnectionString = this._DatabaseConnectionString;
      this._Settings.DefaultServerConnectionString = this._ServerConnectionString;
      this._Settings.UseSSL = this._UseSSL;
      this._Settings.IsGenerateAll = this._IsGenerateAll;
      this._Settings.IsGenerateSilverlight = this._IsGenerateSilverlight;
      this._Settings.IsGetFromRegistry = this._IsGetFromRegistry;
      this._Settings.LogNaming = this._LogNaming;
      this._Settings.LogPath = this._LogPath;
      this._Settings.LogXmlDocument = this._LogXmlDocument;
      this._Settings.ProcessTxnGUID = this._ProcessTxnGUID;
      this._Settings.ConnectionStrings.Clear();
      foreach (ConnectionStringItem connectionString in this.mConnectionStrings)
        this._Settings.ConnectionStrings.Add(new ConnectionStringElement()
        {
          Name = connectionString.Name,
          Value = connectionString.Value
        });
    }
  }
}
