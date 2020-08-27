// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQualityObjectInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQualityObjectInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QualityObjectInquiry qualityObjectInquiry,
      QualityObjectInquiry_Parameters parameters,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QualityObjectInquiryMethod[] methods,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QualityObjectInquiry qualityObjectInquiry,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QualityObjectInquiry qualityObjectInquiry,
      QualityObjectInquiry_Request request,
      out QualityObjectInquiry_Result result);
  }
}
