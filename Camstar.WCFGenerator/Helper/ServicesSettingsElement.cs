// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ServicesSettingsElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class ServicesSettingsElement : ConfigurationElement
  {
    private const string IsGenerateAllProperty = "IsGenerateAll";
    private const string IsGenerateSilverlightProperty = "IsGenerateSilverlight";
    private const string AddressProperty = "Address";
    private const string ProcessTxnGUIDProperty = "ProcessTxnGUID";
    private const string LogXmlDocumentProperty = "LogXmlDocument";
    private const string UseSSLProperty = "UseSSL";
    private const string LogNamingProperty = "LogNaming";
    private const string LogPathProperty = "LogPath";

    [ConfigurationProperty("IsGenerateAll")]
    public bool IsGenerateAll
    {
      get
      {
        return (bool) this[nameof (IsGenerateAll)];
      }
      set
      {
        this[nameof (IsGenerateAll)] = (object) value;
      }
    }

    [ConfigurationProperty("IsGenerateSilverlight")]
    public bool IsGenerateSilverlight
    {
      get
      {
        return (bool) this[nameof (IsGenerateSilverlight)];
      }
      set
      {
        this[nameof (IsGenerateSilverlight)] = (object) value;
      }
    }

    [ConfigurationProperty("Address")]
    public string Address
    {
      get
      {
        return (string) this[nameof (Address)];
      }
      set
      {
        this[nameof (Address)] = (object) value;
      }
    }

    [ConfigurationProperty("ProcessTxnGUID")]
    public bool ProcessTxnGUID
    {
      get
      {
        return (bool) this[nameof (ProcessTxnGUID)];
      }
      set
      {
        this[nameof (ProcessTxnGUID)] = (object) value;
      }
    }

    [ConfigurationProperty("LogXmlDocument")]
    public bool LogXmlDocument
    {
      get
      {
        return (bool) this[nameof (LogXmlDocument)];
      }
      set
      {
        this[nameof (LogXmlDocument)] = (object) value;
      }
    }

    [ConfigurationProperty("UseSSL")]
    public bool UseSSL
    {
      get
      {
        return (bool) this[nameof (UseSSL)];
      }
      set
      {
        this[nameof (UseSSL)] = (object) value;
      }
    }

    [ConfigurationProperty("LogNaming")]
    public string LogNaming
    {
      get
      {
        return (string) this[nameof (LogNaming)];
      }
      set
      {
        this[nameof (LogNaming)] = (object) value;
      }
    }

    [ConfigurationProperty("LogPath")]
    public string LogPath
    {
      get
      {
        return (string) this[nameof (LogPath)];
      }
      set
      {
        this[nameof (LogPath)] = (object) value;
      }
    }
  }
}
