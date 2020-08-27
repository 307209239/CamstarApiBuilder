// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEventLotDetailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEventLotDetailInquiryService
  {
    [OperationContract]
    ResultStatus GetDispositions(
      UserProfile userProfile,
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Parameters parameters,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Parameters parameters,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EventLotDetailInquiryMethod[] methods,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result);
  }
}
