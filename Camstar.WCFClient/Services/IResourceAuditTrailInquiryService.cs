// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceAuditTrailInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceAuditTrailInquiry resourceAuditTrailInquiry,
      ResourceAuditTrailInquiry_Parameters parameters,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceAuditTrailInquiryMethod[] methods,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceAuditTrailInquiry resourceAuditTrailInquiry,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceAuditTrailInquiry resourceAuditTrailInquiry,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result);
  }
}
