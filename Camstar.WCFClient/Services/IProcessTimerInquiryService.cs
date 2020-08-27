// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessTimerInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessTimerInquiryService
  {
    [OperationContract]
    ResultStatus GetTimers(
      UserProfile userProfile,
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Parameters parameters,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Parameters parameters,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessTimerInquiryMethod[] methods,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result);
  }
}
