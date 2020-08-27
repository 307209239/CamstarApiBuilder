// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExecuteProductionProcessService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExecuteProductionProcessService
  {
    [OperationContract]
    ResultStatus AddCompletedTask(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus AssignCellContainerClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_AssignCellContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus AssignCellMfgOrderClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus AssignStationContainerClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_AssignStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus AssignStationMfgOrderClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ClearStationContainerClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ClearStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ClearStationMfgOrderClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_LoadESigDetails_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus LoadProcessListDetails(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus SetLastCompletedTask(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus UpdateCompletedTask(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ValidateCellContainerClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ValidateCellContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ValidateCellMfgOrderClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ValidateStationContainerClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_ValidateStationContainerClearance_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ValidateStationMfgOrderClearance(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Parameters parameters,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExecuteProductionProcessMethod[] methods,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExecuteProductionProcess executeProductionProcess,
      ExecuteProductionProcess_Request request,
      out ExecuteProductionProcess_Result result);
  }
}
