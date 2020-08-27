// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAuditTrailInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AuditTrailInquiry auditTrailInquiry,
      AuditTrailInquiry_Parameters parameters,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AuditTrailInquiryMethod[] methods,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AuditTrailInquiry auditTrailInquiry,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AuditTrailInquiry auditTrailInquiry,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result);
  }
}
