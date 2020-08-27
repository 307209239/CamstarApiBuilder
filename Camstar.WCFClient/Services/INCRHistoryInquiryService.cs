// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRHistoryInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRHistoryInquiry nCRHistoryInquiry,
      NCRHistoryInquiry_Parameters parameters,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRHistoryInquiryMethod[] methods,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRHistoryInquiry nCRHistoryInquiry,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRHistoryInquiry nCRHistoryInquiry,
      NCRHistoryInquiry_Request request,
      out NCRHistoryInquiry_Result result);
  }
}
