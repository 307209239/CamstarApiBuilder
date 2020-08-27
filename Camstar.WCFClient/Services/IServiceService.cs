// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IServiceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IServiceService
  {
    [OperationContract]
    ResultStatus AfterCommitEventFailure(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus CheckWIPMsgElapsedTime(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus CheckWIPMsgRetrievalDate(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExportInfo_Execute(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExportInfo_Initialize(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExportInfo_Initialize_User(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExportInfo_PreExecute(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExportInfo_Validate(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus LiveAlert_Initialize(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus LiveConnect_Initialize(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus LiveRelay_Initialize(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ProcessWIPMsgs(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ValidateWIPMsgs(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus VerifyUser(
      UserProfile userProfile,
      Service service,
      Service_Parameters parameters,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ServiceMethod[] methods,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Service service,
      Service_Request request,
      out Service_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Service service,
      Service_Request request,
      out Service_Result result);
  }
}
