// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWIPMessageEntityInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWIPMessageEntityInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WIPMessageEntityInquiry wIPMessageEntityInquiry,
      WIPMessageEntityInquiry_Parameters parameters,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WIPMessageEntityInquiryMethod[] methods,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WIPMessageEntityInquiry wIPMessageEntityInquiry,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WIPMessageEntityInquiry wIPMessageEntityInquiry,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result);
  }
}
