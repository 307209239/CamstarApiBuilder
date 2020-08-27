// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QueryService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QueryService : WCFServiceBase
  {
    public QueryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQueryService), userProfile);
    }

    public ResultStatus Execute(
      string queryName,
      QueryParameters parameters,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = (RecordSet) null;
      try
      {
        return ((IQueryService) this._Channel).Execute(this._UserProfile, queryName, parameters, options, out recordSet);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteMultiple(QueryItem[] queries, out RecordSet[] recordSets)
    {
      recordSets = (RecordSet[]) null;
      try
      {
        return ((IQueryService) this._Channel).ExecuteMultiple(this._UserProfile, queries, out recordSets);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteAdHoc(
      string queryText,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = (RecordSet) null;
      try
      {
        return ((IQueryService) this._Channel).ExecuteAdHoc(this._UserProfile, queryText, options, out recordSet);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteXMLQuery(
      string xmlQueryText,
      QueryOptions options,
      out RecordSet recordSet)
    {
      recordSet = (RecordSet) null;
      try
      {
        return ((IQueryService) this._Channel).ExecuteXMLQuery(this._UserProfile, xmlQueryText, options, out recordSet);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
