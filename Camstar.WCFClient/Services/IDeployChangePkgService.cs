// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDeployChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDeployChangePkgService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_LoadESigDetails_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Parameters parameters,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DeployChangePkgMethod[] methods,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DeployChangePkg deployChangePkg,
      DeployChangePkg_Request request,
      out DeployChangePkg_Result result);
  }
}
