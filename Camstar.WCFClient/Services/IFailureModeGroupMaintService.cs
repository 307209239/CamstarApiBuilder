// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFailureModeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFailureModeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_LoadESigDetails_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Parameters parameters,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FailureModeGroupMaintMethod[] methods,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FailureModeGroupMaint failureModeGroupMaint,
      FailureModeGroupMaint_Request request,
      out FailureModeGroupMaint_Result result);
  }
}
