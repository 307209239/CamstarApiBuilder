// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPlanTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPlanTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_LoadESigDetails_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Parameters parameters,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PlanTemplateMaintMethod[] methods,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PlanTemplateMaint planTemplateMaint,
      PlanTemplateMaint_Request request,
      out PlanTemplateMaint_Result result);
  }
}
