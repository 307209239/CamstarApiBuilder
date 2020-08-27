// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIVirtualPageMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIVirtualPageMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_LoadESigDetails_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIVirtualPageMaintMethod[] methods,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result);
  }
}
