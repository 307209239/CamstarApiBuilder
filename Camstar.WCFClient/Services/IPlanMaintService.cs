// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPlanMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_LoadESigDetails_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Parameters parameters,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PlanMaintMethod[] methods,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PlanMaint planMaint,
      PlanMaint_Request request,
      out PlanMaint_Result result);
  }
}
