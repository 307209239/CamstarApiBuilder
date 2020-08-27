// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.QueryService
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;

namespace Camstar.WCF.Service
{
  public class QueryService : ServiceBase, IQueryService
  {
    public ResultStatus Execute(
      UserProfile userProfile,
      string queryName,
      QueryParameters parameters,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = new RecordSet();
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallQuery(queryName, parameters, options, recordSet, resultStatus, false);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteMultiple(
      UserProfile userProfile,
      QueryItem[] queries,
      out RecordSet[] recordSets)
    {
      recordSets = (RecordSet[]) null;
      try
      {
        recordSets = new RecordSet[queries.Length];
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallQueries(queries, recordSets, resultStatus);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteAdHoc(
      UserProfile userProfile,
      string queryText,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = new RecordSet();
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallQuery(queryText, (QueryParameters) null, options, recordSet, resultStatus, true);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteXMLQuery(
      UserProfile userProfile,
      string xmlQueryText,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = new RecordSet();
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallXmlQuery(xmlQueryText, options, recordSet, resultStatus);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
