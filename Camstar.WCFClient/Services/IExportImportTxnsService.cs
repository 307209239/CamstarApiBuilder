// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportImportTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportImportTxnsService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessage(
      UserProfile userProfile,
      ExportImportTxns exportImportTxns,
      ExportImportTxns_SetCompletionMessage_Parameters parameters,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportImportTxnsMethod[] methods,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExportImportTxns exportImportTxns,
      ExportImportTxns_Request request,
      out ExportImportTxns_Result result);
  }
}
