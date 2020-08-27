// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPackageInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPackageInquiryService
  {
    [OperationContract]
    ResultStatus GetPackages(
      UserProfile userProfile,
      PackageInquiry packageInquiry,
      PackageInquiry_Parameters parameters,
      PackageInquiry_Request request,
      out PackageInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PackageInquiry packageInquiry,
      PackageInquiry_Parameters parameters,
      PackageInquiry_Request request,
      out PackageInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PackageInquiryMethod[] methods,
      PackageInquiry_Request request,
      out PackageInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PackageInquiry packageInquiry,
      PackageInquiry_Request request,
      out PackageInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PackageInquiry packageInquiry,
      PackageInquiry_Request request,
      out PackageInquiry_Result result);
  }
}
