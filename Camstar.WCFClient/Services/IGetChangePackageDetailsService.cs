// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetChangePackageDetailsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetChangePackageDetailsService
  {
    [OperationContract]
    ResultStatus GetApprovalDetails(
      UserProfile userProfile,
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);

    [OperationContract]
    ResultStatus GetPackageDetails(
      UserProfile userProfile,
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetChangePackageDetailsMethod[] methods,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result);
  }
}
