// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICreateEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICreateEventService
  {
    [OperationContract]
    ResultStatus AddHistoryCrossRefs(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus GetEventName(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus SubmitEvent(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus ValidateEvent(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CreateEventMethod[] methods,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result);
  }
}
