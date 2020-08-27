// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IApprovalCycleInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IApprovalCycleInquiryService
  {
    [OperationContract]
    ResultStatus GetApprovalCycleDetails(
      UserProfile userProfile,
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Parameters parameters,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Parameters parameters,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ApprovalCycleInquiryMethod[] methods,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result);
  }
}
