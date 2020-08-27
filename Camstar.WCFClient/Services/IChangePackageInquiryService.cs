// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangePackageInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangePackageInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangePackageInquiry changePackageInquiry,
      ChangePackageInquiry_Parameters parameters,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangePackageInquiryMethod[] methods,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangePackageInquiry changePackageInquiry,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangePackageInquiry changePackageInquiry,
      ChangePackageInquiry_Request request,
      out ChangePackageInquiry_Result result);
  }
}
