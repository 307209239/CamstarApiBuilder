// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerInquiryService
  {
    [OperationContract]
    ResultStatus GetChildContainers(
      UserProfile userProfile,
      ContainerInquiry containerInquiry,
      ContainerInquiry_GetChildContainers_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);

    [OperationContract]
    ResultStatus GetContainers(
      UserProfile userProfile,
      ContainerInquiry containerInquiry,
      ContainerInquiry_GetContainers_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerInquiry containerInquiry,
      ContainerInquiry_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerInquiryMethod[] methods,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerInquiry containerInquiry,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerInquiry containerInquiry,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result);
  }
}
