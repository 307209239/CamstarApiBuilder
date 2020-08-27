// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivityTemplateInvestigationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivityTemplateInvestigationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_LoadESigDetails_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Parameters parameters,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaintMethod[] methods,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivityTemplateInvestigationMaint activityTemplateInvestigationMaint,
      ActivityTemplateInvestigationMaint_Request request,
      out ActivityTemplateInvestigationMaint_Result result);
  }
}
