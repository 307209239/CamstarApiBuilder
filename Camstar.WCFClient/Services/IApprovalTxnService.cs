// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IApprovalTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IApprovalTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetEntry(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_LoadESigDetails_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Parameters parameters,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ApprovalTxnMethod[] methods,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ApprovalTxn approvalTxn,
      ApprovalTxn_Request request,
      out ApprovalTxn_Result result);
  }
}
