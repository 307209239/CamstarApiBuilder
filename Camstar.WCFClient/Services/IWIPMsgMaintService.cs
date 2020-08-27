// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWIPMsgMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWIPMsgMaintService
  {
    [OperationContract]
    ResultStatus AddAllKeyDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus AddLabelDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus AddOperationDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus ClearAllKey(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus DeleteDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus DeleteLabelKey(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus DeleteOprKey(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus LoadDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_LoadESigDetails_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsAllDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsLabelDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsOperationDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SaveDetail(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessageAdd(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessageChange(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessageDelete(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus SetCompletionMessageLoad(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WIPMsgMaintMethod[] methods,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result);
  }
}
