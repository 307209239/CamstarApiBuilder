// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrackTargetDeploymentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrackTargetDeploymentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus GetNextAvailableTargetDeployment(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_LoadESigDetails_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Parameters parameters,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrackTargetDeploymentMethod[] methods,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrackTargetDeployment trackTargetDeployment,
      TrackTargetDeployment_Request request,
      out TrackTargetDeployment_Result result);
  }
}
