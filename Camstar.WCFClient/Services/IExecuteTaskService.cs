// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExecuteTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExecuteTaskService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_LoadESigDetails_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus StartTaskTimers(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus ValidateTaskTimers(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Parameters parameters,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExecuteTaskMethod[] methods,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExecuteTask executeTask,
      ExecuteTask_Request request,
      out ExecuteTask_Result result);
  }
}
