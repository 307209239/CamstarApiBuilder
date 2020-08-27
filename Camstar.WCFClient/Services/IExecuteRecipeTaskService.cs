// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExecuteRecipeTaskService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExecuteRecipeTaskService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus GetMaterialSelectionValues(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_GetMaterialSelectionValues_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_LoadESigDetails_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Parameters parameters,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExecuteRecipeTaskMethod[] methods,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExecuteRecipeTask executeRecipeTask,
      ExecuteRecipeTask_Request request,
      out ExecuteRecipeTask_Result result);
  }
}
