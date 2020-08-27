// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivationInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivationInquiryService
  {
    [OperationContract]
    ResultStatus GetPackages(
      UserProfile userProfile,
      ActivationInquiry activationInquiry,
      ActivationInquiry_Parameters parameters,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivationInquiry activationInquiry,
      ActivationInquiry_Parameters parameters,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivationInquiryMethod[] methods,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivationInquiry activationInquiry,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivationInquiry activationInquiry,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result);
  }
}
