// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateChangePkgService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus CreateSheet(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadCollaboratorTemplate(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadDefaultMessages(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_LoadESigDetails_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus SaveApprovalSheet(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus SaveCollaboratorDetails(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus SendEmailToCollaborators(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateChangePkgMethod[] methods,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result);
  }
}
