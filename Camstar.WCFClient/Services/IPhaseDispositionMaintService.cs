// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPhaseDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPhaseDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_LoadESigDetails_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Parameters parameters,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PhaseDispositionMaintMethod[] methods,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PhaseDispositionMaint phaseDispositionMaint,
      PhaseDispositionMaint_Request request,
      out PhaseDispositionMaint_Result result);
  }
}
