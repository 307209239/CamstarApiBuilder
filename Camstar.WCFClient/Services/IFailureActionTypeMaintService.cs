// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFailureActionTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFailureActionTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_LoadESigDetails_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Parameters parameters,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FailureActionTypeMaintMethod[] methods,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FailureActionTypeMaint failureActionTypeMaint,
      FailureActionTypeMaint_Request request,
      out FailureActionTypeMaint_Result result);
  }
}
