// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignChecklistToEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignChecklistToEventService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignChecklistToEventMethod[] methods,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result);
  }
}
