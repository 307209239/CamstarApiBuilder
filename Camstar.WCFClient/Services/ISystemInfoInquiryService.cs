// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISystemInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISystemInfoInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SystemInfoInquiry systemInfoInquiry,
      SystemInfoInquiry_Parameters parameters,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SystemInfoInquiryMethod[] methods,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SystemInfoInquiry systemInfoInquiry,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SystemInfoInquiry systemInfoInquiry,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result);
  }
}
