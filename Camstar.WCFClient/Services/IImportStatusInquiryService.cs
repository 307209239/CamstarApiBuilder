// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IImportStatusInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IImportStatusInquiryService
  {
    [OperationContract]
    ResultStatus GetImportSetStatus(
      UserProfile userProfile,
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus GetStatusDetails(
      UserProfile userProfile,
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Parameters parameters,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ImportStatusInquiryMethod[] methods,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ImportStatusInquiry importStatusInquiry,
      ImportStatusInquiry_Request request,
      out ImportStatusInquiry_Result result);
  }
}
