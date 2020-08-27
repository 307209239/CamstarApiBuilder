// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRemoteReceiveService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRemoteReceiveService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_LoadESigDetails_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus SetupRemoteStart(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus SetupShip(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Parameters parameters,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RemoteReceiveMethod[] methods,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RemoteReceive remoteReceive,
      RemoteReceive_Request request,
      out RemoteReceive_Result result);
  }
}
