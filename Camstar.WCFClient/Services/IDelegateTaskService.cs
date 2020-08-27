// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegateTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegateTaskService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus DelegateApprover(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_DelegateApprover_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus DelegateCollaborator(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_DelegateCollaborator_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_LoadESigDetails_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Parameters parameters,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegateTaskMethod[] methods,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegateTask delegateTask,
      DelegateTask_Request request,
      out DelegateTask_Result result);
  }
}
