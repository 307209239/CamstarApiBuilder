// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegateDateInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegateDateInquiryService
  {
    [OperationContract]
    ResultStatus GetTasks(
      UserProfile userProfile,
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Parameters parameters,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Parameters parameters,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegateDateInquiryMethod[] methods,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result);
  }
}
