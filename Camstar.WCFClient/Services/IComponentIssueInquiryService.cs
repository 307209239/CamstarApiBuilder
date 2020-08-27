// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentIssueInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentIssueInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentIssueInquiry componentIssueInquiry,
      ComponentIssueInquiry_Parameters parameters,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentIssueInquiryMethod[] methods,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentIssueInquiry componentIssueInquiry,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentIssueInquiry componentIssueInquiry,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result);
  }
}
