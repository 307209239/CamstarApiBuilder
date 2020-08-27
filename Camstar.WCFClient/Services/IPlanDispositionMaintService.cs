// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPlanDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPlanDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_LoadESigDetails_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Parameters parameters,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PlanDispositionMaintMethod[] methods,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PlanDispositionMaint planDispositionMaint,
      PlanDispositionMaint_Request request,
      out PlanDispositionMaint_Result result);
  }
}
