// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIProviderComponentMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIProviderComponentMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_LoadESigDetails_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIProviderComponentMaintMethod[] methods,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result);
  }
}
