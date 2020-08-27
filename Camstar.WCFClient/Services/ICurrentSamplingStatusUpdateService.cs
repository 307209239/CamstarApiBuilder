// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICurrentSamplingStatusUpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICurrentSamplingStatusUpdateService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_LoadESigDetails_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Parameters parameters,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CurrentSamplingStatusUpdateMethod[] methods,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CurrentSamplingStatusUpdate currentSamplingStatusUpdate,
      CurrentSamplingStatusUpdate_Request request,
      out CurrentSamplingStatusUpdate_Result result);
  }
}
