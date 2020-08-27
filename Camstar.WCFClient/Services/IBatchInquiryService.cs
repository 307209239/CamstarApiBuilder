// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBatchInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBatchInquiryService
  {
    [OperationContract]
    ResultStatus GetMaterialContainers(
      UserProfile userProfile,
      BatchInquiry batchInquiry,
      BatchInquiry_Parameters parameters,
      BatchInquiry_Request request,
      out BatchInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BatchInquiry batchInquiry,
      BatchInquiry_Parameters parameters,
      BatchInquiry_Request request,
      out BatchInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BatchInquiryMethod[] methods,
      BatchInquiry_Request request,
      out BatchInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BatchInquiry batchInquiry,
      BatchInquiry_Request request,
      out BatchInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BatchInquiry batchInquiry,
      BatchInquiry_Request request,
      out BatchInquiry_Result result);
  }
}
