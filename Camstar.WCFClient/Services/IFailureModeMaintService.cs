// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFailureModeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFailureModeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_LoadESigDetails_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Parameters parameters,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FailureModeMaintMethod[] methods,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FailureModeMaint failureModeMaint,
      FailureModeMaint_Request request,
      out FailureModeMaint_Result result);
  }
}
