// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetImpactDetailsInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetImpactDetailsInquiryService
  {
    [OperationContract]
    ResultStatus GetImpactPackageDetails(
      UserProfile userProfile,
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Parameters parameters,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Parameters parameters,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetImpactDetailsInquiryMethod[] methods,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result);
  }
}
