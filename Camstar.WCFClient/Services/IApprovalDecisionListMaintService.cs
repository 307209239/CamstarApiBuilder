// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IApprovalDecisionListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IApprovalDecisionListMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_LoadESigDetails_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Parameters parameters,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ApprovalDecisionListMaintMethod[] methods,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ApprovalDecisionListMaint approvalDecisionListMaint,
      ApprovalDecisionListMaint_Request request,
      out ApprovalDecisionListMaint_Result result);
  }
}
