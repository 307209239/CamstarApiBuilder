// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivityInvestigationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivityInvestigationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_LoadESigDetails_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Parameters parameters,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivityInvestigationMaintMethod[] methods,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivityInvestigationMaint activityInvestigationMaint,
      ActivityInvestigationMaint_Request request,
      out ActivityInvestigationMaint_Result result);
  }
}
