// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIPreferenceMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIPreferenceMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_LoadESigDetails_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIPreferenceMaintMethod[] methods,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result);
  }
}
