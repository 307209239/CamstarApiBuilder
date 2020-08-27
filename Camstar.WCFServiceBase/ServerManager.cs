// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.ServerManager
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using Camstar.Utility;
using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Web;
using System.Web.Configuration;

namespace Camstar.WCF.Service
{
  public class ServerManager
  {
    private static string s_DefaultServerConnectionString = WebConfigurationManager.AppSettings["DefaultServerConnectionString"];
    private static ConcurrentDictionary<string, ServerConnectionSettings> s_ServerConnectionSettings = new ConcurrentDictionary<string, ServerConnectionSettings>(2, 10);
    private static ServerConnectionPool s_ConnPool = new ServerConnectionPool();
    private ServerConnection _serverConnection;
    private InSiteXmlParser _inSiteXmlParser;
    private Log _Log;

    public ServerManager(string serviceName, UserProfile userProfile)
    {
      if (userProfile == null)
        throw new Exception("User Profile is required");
      bool fromCache;
      this._serverConnection = ServerManager.s_ConnPool.GetServerConnection(out fromCache);
      if (this._serverConnection != null && (!fromCache || !string.IsNullOrWhiteSpace(userProfile.ServerName)))
      {
        string key = !string.IsNullOrEmpty(userProfile.ServerName) ? userProfile.ServerName : ServerManager.s_DefaultServerConnectionString;
        ServerConnectionSettings defaultSettings;
        if (!ServerManager.s_ServerConnectionSettings.TryGetValue(key, out defaultSettings))
        {
          ConnectionStringSettings connectionString = WebConfigurationManager.ConnectionStrings[key];
          if (connectionString == null)
          {
            string message = string.Format("Connection information for server '{0}' could not be found.\r\n", (object) key);
            if (HttpContext.Current != null)
              HttpContext.Current.Trace.Warn(message);
            throw new Exception(message);
          }
          defaultSettings = ServerConnectionSettings.DefaultSettings;
          defaultSettings.Host = connectionString.ConnectionString.Split(':')[0];
          defaultSettings.Port = int.Parse(connectionString.ConnectionString.Split(':')[1]);
          ServerManager.s_ServerConnectionSettings.TryAdd(key, defaultSettings);
        }
        if (defaultSettings != null)
        {
          this._serverConnection.Host = defaultSettings.Host;
          this._serverConnection.Port = defaultSettings.Port;
        }
      }
      this._inSiteXmlParser = new InSiteXmlParser(serviceName.Remove(serviceName.Length - "Service".Length), userProfile);
      this._Log = new Log(serviceName, userProfile);
    }

    public void CallServiceMethod(
      string name,
      DCObject cdo,
      Parameters parameters,
      Request request,
      Result result,
      ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._inSiteXmlParser.SetService();
      this._inSiteXmlParser.ToXmlAsMethodCall(name, cdo, parameters);
      this._inSiteXmlParser.SetRequest(request);
      string empty = string.Empty;
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml(name, this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml(name, str, false, resultStatus);
      this._inSiteXmlParser.ToObjectsAsMethodCall(str, result, resultStatus);
    }

    public void CallXmlQuery(
      string xmlQueryText,
      QueryOptions options,
      RecordSet recordSet,
      ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._inSiteXmlParser.ToXmlAsXmlQuery(xmlQueryText, options);
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml("XmlQuery", this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml("XmlQuery", str, false, resultStatus);
      this._inSiteXmlParser.ToObjectsAsQuery(str, recordSet, resultStatus);
    }

    public void CallQuery(
      string name,
      QueryParameters parameters,
      QueryOptions options,
      RecordSet recordSet,
      ResultStatus resultStatus,
      bool isAdHoc)
    {
      resultStatus.IsSuccess = true;
      if (!isAdHoc)
        this._inSiteXmlParser.ToXmlAsQuery(name, parameters, options, true, true);
      else
        this._inSiteXmlParser.ToXmlAsQueryAdHoc(name, options);
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml(isAdHoc ? "ExecuteAdHoc" : "Execute", this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml(isAdHoc ? "ExecuteAdHoc" : "Execute", str, false, resultStatus);
      this._inSiteXmlParser.ToObjectsAsQuery(str, recordSet, resultStatus);
    }

    public void CallQueries(QueryItem[] queries, RecordSet[] recordSet, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      int num = 1;
      foreach (QueryItem query in queries)
      {
        this._inSiteXmlParser.ToXmlAsQuery(query.Name, query.QueryParameters, query.Options, num == 1, num == queries.Length);
        ++num;
      }
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml("Execute", this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml("Execute", str, false, resultStatus);
      this._inSiteXmlParser.ToObjectsAsQueries(str, recordSet, resultStatus);
    }

    public string CallDirectAccessServer(string inboundXML, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._inSiteXmlParser.DirectRequest(inboundXML);
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml("DirectSubmit", this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml("DirectSubmit", str, false, resultStatus);
      this._inSiteXmlParser.ToDirectResult(str, resultStatus);
      return str;
    }

    public void CallServiceMethods(
      Method[] methods,
      Request request,
      Result result,
      ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._inSiteXmlParser.SetService();
      foreach (object method in methods)
      {
        UnknownObjectReader unknownObjectReader = new UnknownObjectReader(method);
        string empty = string.Empty;
        if (unknownObjectReader["ServiceMethod"] != null)
          empty = unknownObjectReader["ServiceMethod"].Value.ToString();
        DCObject cdo = (DCObject) null;
        if (unknownObjectReader["Cdo"] != null)
          cdo = unknownObjectReader["Cdo"].Value as DCObject;
        Parameters parameters = (Parameters) null;
        if (unknownObjectReader["Parameters"] != null)
          parameters = unknownObjectReader["Parameters"].Value as Parameters;
        this._inSiteXmlParser.ToXmlAsMethodCall(empty, cdo, parameters);
      }
      this._inSiteXmlParser.SetRequest(request);
      string empty1 = string.Empty;
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml("Methods", this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml("Methods", str, false, resultStatus);
      this._inSiteXmlParser.ToObjectsAsMethodCall(str, result, resultStatus);
    }

    public void Login(SessionData sessionData, ResultStatus resultStatus)
    {
      this._inSiteXmlParser.ToXmlLogin();
      string empty = string.Empty;
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml(nameof (Login), this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml(nameof (Login), str, false, resultStatus);
      this._inSiteXmlParser.ToSessionObject(str, sessionData, resultStatus);
    }

    public void GetLabels(LabelRequest request, LabelResult result, ResultStatus resultStatus)
    {
      this._inSiteXmlParser.ToXmlLabels(request);
      string empty = string.Empty;
      this._serverConnection.InboundXML = this._inSiteXmlParser.GetXmlAsString();
      this._Log.WriteXml(nameof (GetLabels), this._serverConnection.InboundXML, true, resultStatus);
      string str = this._serverConnection.Submit();
      this._Log.WriteXml(nameof (GetLabels), str, false, resultStatus);
      this._inSiteXmlParser.ToLabelsObject(str, result, resultStatus);
    }

    public void Close()
    {
      ServerManager.s_ConnPool.ReleaseServerConnection(this._serverConnection);
      this._serverConnection = (ServerConnection) null;
    }
  }
}
