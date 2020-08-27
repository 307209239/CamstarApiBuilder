// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IIssueReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IIssueReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_LoadESigDetails_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      IssueReasonMaintMethod[] methods,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result);
  }
}
