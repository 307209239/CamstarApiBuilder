// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IModelingAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IModelingAuditTrailInquiryService
  {
    [OperationContract]
    ResultStatus GetAuditTrailDetails(
      UserProfile userProfile,
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetAuditTrailHeaders(
      UserProfile userProfile,
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ModelingAuditTrailInquiryMethod[] methods,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result);
  }
}
