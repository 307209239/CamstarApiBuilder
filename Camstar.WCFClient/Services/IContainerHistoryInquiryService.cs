// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerHistoryInquiryService
  {
    [OperationContract]
    ResultStatus GetHistories(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetHistoryDisplayTexts(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus InitInquiryDetail(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus SetSelectedHistoryItem(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerHistoryInquiryMethod[] methods,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result);
  }
}
