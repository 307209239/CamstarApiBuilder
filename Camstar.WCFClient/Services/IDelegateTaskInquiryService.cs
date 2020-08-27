// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegateTaskInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegateTaskInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegateTaskInquiry delegateTaskInquiry,
      DelegateTaskInquiry_Parameters parameters,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegateTaskInquiryMethod[] methods,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegateTaskInquiry delegateTaskInquiry,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegateTaskInquiry delegateTaskInquiry,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result);
  }
}
