// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIPageFlowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIPageFlowMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_LoadESigDetails_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIPageFlowMaintMethod[] methods,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result);
  }
}
