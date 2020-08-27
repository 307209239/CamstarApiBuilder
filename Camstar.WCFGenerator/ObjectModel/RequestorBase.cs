// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.RequestorBase
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Collections;
using System.Text;

namespace Camstar.WCF.Generator.ObjectModel
{
  public abstract class RequestorBase
  {
    private static bool _isGetFromRegistry = false;
    private static string _connectionString = string.Empty;
    protected const string REGISTRY_KEY = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Common";
    protected const string REGISTRY_KEY_64 = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Common";

    public static RequestorBase CurrentRequestor { get; set; }

    public static bool IsGetFromRegistry
    {
      get
      {
        return RequestorBase._isGetFromRegistry;
      }
      set
      {
        if (RequestorBase._isGetFromRegistry != value)
          RequestorBase.CurrentRequestor = (RequestorBase) null;
        RequestorBase._isGetFromRegistry = value;
      }
    }

    public static string ConnectionString
    {
      get
      {
        return RequestorBase._connectionString;
      }
      set
      {
        if (RequestorBase._connectionString != value)
          RequestorBase.CurrentRequestor = (RequestorBase) null;
        RequestorBase._connectionString = value;
      }
    }

    protected Hashtable ParseConnectionString(string connectionString)
    {
      Hashtable hashtable = new Hashtable();
      string str1 = connectionString;
      char[] chArray = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray))
      {
        if (!string.IsNullOrEmpty(str2))
        {
          string[] strArray = str2.Split('=');
          hashtable.Add((object) strArray[0].Trim().ToLower(), (object) strArray[1].Trim());
        }
      }
      return hashtable;
    }

    protected string ParseHashtable(Hashtable connectionValues)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (string key in (IEnumerable) connectionValues.Keys)
        stringBuilder.Append(key + "=" + connectionValues[(object) key] + ";");
      return stringBuilder.ToString();
    }
  }
}
