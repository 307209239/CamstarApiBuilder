// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMfgAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMfgAuditTrailInquiryService
  {
    [OperationContract]
    ResultStatus GetParameters(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_GetParameters_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GMTToLocal(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_GMTToLocal_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus InitSummaryAndDetails(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MfgAuditTrailInquiryMethod[] methods,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result);
  }
}
