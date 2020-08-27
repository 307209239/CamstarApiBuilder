// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPlanTemplateDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPlanTemplateDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_LoadESigDetails_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Parameters parameters,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PlanTemplateDispositionMaintMethod[] methods,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PlanTemplateDispositionMaint planTemplateDispositionMaint,
      PlanTemplateDispositionMaint_Request request,
      out PlanTemplateDispositionMaint_Result result);
  }
}
