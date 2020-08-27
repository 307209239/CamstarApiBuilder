// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecurringDateReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecurringDateReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_LoadESigDetails_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Parameters parameters,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecurringDateReqMaintMethod[] methods,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecurringDateReqMaint recurringDateReqMaint,
      RecurringDateReqMaint_Request request,
      out RecurringDateReqMaint_Result result);
  }
}
