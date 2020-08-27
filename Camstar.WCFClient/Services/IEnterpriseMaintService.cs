// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEnterpriseMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEnterpriseMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_LoadESigDetails_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Parameters parameters,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EnterpriseMaintMethod[] methods,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EnterpriseMaint enterpriseMaint,
      EnterpriseMaint_Request request,
      out EnterpriseMaint_Result result);
  }
}
