// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.IQueryService
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.ServiceModel;

namespace Camstar.WCF.Service
{
  [ServiceContract]
  public interface IQueryService
  {
    [OperationContract]
    ResultStatus Execute(
      UserProfile userProfile,
      string queryName,
      QueryParameters Parameters,
      QueryOptions options,
      out RecordSet recordSet);

    [OperationContract]
    ResultStatus ExecuteAdHoc(
      UserProfile userProfile,
      string queryText,
      QueryOptions options,
      out RecordSet recordSet);

    [OperationContract]
    ResultStatus ExecuteXMLQuery(
      UserProfile userProfile,
      string xmlQueryText,
      QueryOptions options,
      out RecordSet recordSet);

    [OperationContract]
    ResultStatus ExecuteMultiple(
      UserProfile userProfile,
      QueryItem[] queries,
      out RecordSet[] recordSets);
  }
}
