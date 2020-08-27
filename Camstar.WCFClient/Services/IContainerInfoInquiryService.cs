// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerInfoInquiryService
  {
    [OperationContract]
    ResultStatus ContainerInfoInquiry_GetContainerInfo(
      UserProfile userProfile,
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Parameters parameters,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Parameters parameters,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerInfoInquiryMethod[] methods,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result);
  }
}
