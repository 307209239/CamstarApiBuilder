// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivateChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivateChangePkgService
  {
    [OperationContract]
    ResultStatus CheckIfPreReqPkgsActivated(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_LoadESigDetails_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Parameters parameters,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivateChangePkgMethod[] methods,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivateChangePkg activateChangePkg,
      ActivateChangePkg_Request request,
      out ActivateChangePkg_Result result);
  }
}
