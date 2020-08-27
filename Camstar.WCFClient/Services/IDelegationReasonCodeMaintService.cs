// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegationReasonCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegationReasonCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_LoadESigDetails_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Parameters parameters,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegationReasonCodeMaintMethod[] methods,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegationReasonCodeMaint delegationReasonCodeMaint,
      DelegationReasonCodeMaint_Request request,
      out DelegationReasonCodeMaint_Result result);
  }
}
