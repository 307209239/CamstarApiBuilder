// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEligibleContainersInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEligibleContainersInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Parameters parameters,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result);

    [OperationContract]
    ResultStatus LoadEligibleContainers(
      UserProfile userProfile,
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_LoadEligibleContainers_Parameters parameters,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EligibleContainersInquiryMethod[] methods,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result);
  }
}
