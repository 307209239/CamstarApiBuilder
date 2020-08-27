// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivityMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_LoadESigDetails_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Parameters parameters,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivityMaintMethod[] methods,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivityMaint activityMaint,
      ActivityMaint_Request request,
      out ActivityMaint_Result result);
  }
}
