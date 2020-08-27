// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRemoteStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRemoteStartService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_LoadESigDetails_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Parameters parameters,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RemoteStartMethod[] methods,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RemoteStart remoteStart,
      RemoteStart_Request request,
      out RemoteStart_Result result);
  }
}
