// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IStartChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IStartChangePkgService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_LoadESigDetails_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus SaveApprovalTemplate(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus SaveCollaboratorTemplate(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus Validate_ServerCatalogSetUp(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus ValidateChangePackage(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      StartChangePkgMethod[] methods,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result);
  }
}
