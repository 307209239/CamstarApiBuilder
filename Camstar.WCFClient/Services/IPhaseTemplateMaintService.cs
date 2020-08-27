// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPhaseTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPhaseTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_LoadESigDetails_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Parameters parameters,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PhaseTemplateMaintMethod[] methods,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PhaseTemplateMaint phaseTemplateMaint,
      PhaseTemplateMaint_Request request,
      out PhaseTemplateMaint_Result result);
  }
}
