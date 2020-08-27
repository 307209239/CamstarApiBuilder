// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUIProviderComponentInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUIProviderComponentInquiryService
  {
    [OperationContract]
    ResultStatus GetPageFlowContentByGUID(
      UserProfile userProfile,
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);

    [OperationContract]
    ResultStatus GetPersonalizationContentByOwner(
      UserProfile userProfile,
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UIProviderComponentInquiryMethod[] methods,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result);
  }
}
