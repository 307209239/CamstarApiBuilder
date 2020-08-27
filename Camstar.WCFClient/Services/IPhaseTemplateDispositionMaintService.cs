// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPhaseTemplateDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPhaseTemplateDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_LoadESigDetails_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Parameters parameters,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PhaseTemplateDispositionMaintMethod[] methods,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PhaseTemplateDispositionMaint phaseTemplateDispositionMaint,
      PhaseTemplateDispositionMaint_Request request,
      out PhaseTemplateDispositionMaint_Result result);
  }
}
