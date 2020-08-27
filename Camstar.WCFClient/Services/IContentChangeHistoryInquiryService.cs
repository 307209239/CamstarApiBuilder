// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContentChangeHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContentChangeHistoryInquiryService
  {
    [OperationContract]
    ResultStatus GetAuditTrailHeaders(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus SetEndTimestamp(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus SetInstances(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus SetStartTimestamp(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContentChangeHistoryInquiryMethod[] methods,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result);
  }
}
