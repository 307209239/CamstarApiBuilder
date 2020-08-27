// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_SecurityAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_SecurityAuditTrailInquiryService
  {
    [OperationContract]
    ResultStatus GetAuditTrailDetails(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetAuditTrailHeaders(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiryMethod[] methods,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result);
  }
}
