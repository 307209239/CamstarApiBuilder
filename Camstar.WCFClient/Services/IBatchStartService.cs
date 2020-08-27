// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBatchStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBatchStartService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_LoadESigDetails_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Parameters parameters,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BatchStartMethod[] methods,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BatchStart batchStart,
      BatchStart_Request request,
      out BatchStart_Result result);
  }
}
