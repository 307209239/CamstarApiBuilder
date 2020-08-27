// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegationTaskMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegationTaskMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_LoadESigDetails_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus Validate(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Parameters parameters,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegationTaskMaintMethod[] methods,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegationTaskMaint delegationTaskMaint,
      DelegationTaskMaint_Request request,
      out DelegationTaskMaint_Result result);
  }
}
