// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHistoryViewMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHistoryViewMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_LoadESigDetails_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HistoryViewMaintMethod[] methods,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result);
  }
}
