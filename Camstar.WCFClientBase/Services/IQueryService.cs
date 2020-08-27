// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQueryService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
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
    ResultStatus ExecuteMultiple(
      UserProfile userProfile,
      QueryItem[] queries,
      out RecordSet[] recordSets);

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
  }
}
