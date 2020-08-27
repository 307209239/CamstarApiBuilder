// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventFailureActionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventFailureActionsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetEventActions(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_GetEventActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetFailures(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_GetFailures_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus ModifyEventActions(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus ModifyFailures(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventFailureActionsMethod[] methods,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result);
  }
}
