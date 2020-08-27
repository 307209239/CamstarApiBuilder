// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ExecuteChecklist(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetChecklistEntries(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetCrossRefDetails(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetCrossReferences(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetDetails(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetEventDetails(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus SaveApprovalSheet(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus SaveCrossReferences(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus SubmitEvent(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ValidateEvent(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ValidateIfChecklistHasResponses(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ValidateOwner(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Parameters parameters,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventMethod[] methods,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEvent updateEvent,
      UpdateEvent_Request request,
      out UpdateEvent_Result result);
  }
}
