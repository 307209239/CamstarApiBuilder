// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIPersonalizationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIPersonalizationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_LoadESigDetails_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIPersonalizationMaintMethod[] methods,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result);
  }
}
