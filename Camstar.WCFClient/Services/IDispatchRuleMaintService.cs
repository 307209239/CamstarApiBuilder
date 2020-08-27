// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDispatchRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDispatchRuleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_LoadESigDetails_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Parameters parameters,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DispatchRuleMaintMethod[] methods,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DispatchRuleMaint dispatchRuleMaint,
      DispatchRuleMaint_Request request,
      out DispatchRuleMaint_Result result);
  }
}
