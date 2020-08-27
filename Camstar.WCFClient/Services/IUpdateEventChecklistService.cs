// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventChecklistService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventChecklistService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus ValidateIfChecklistHasResponses(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Parameters parameters,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventChecklistMethod[] methods,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventChecklist updateEventChecklist,
      UpdateEventChecklist_Request request,
      out UpdateEventChecklist_Result result);
  }
}
