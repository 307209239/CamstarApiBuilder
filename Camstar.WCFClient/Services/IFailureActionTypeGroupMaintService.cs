// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFailureActionTypeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFailureActionTypeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_LoadESigDetails_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Parameters parameters,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FailureActionTypeGroupMaintMethod[] methods,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FailureActionTypeGroupMaint failureActionTypeGroupMaint,
      FailureActionTypeGroupMaint_Request request,
      out FailureActionTypeGroupMaint_Result result);
  }
}
