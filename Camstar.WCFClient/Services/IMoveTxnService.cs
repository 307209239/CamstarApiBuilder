// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveTxnService
  {
    [OperationContract]
    ResultStatus AdditionalValidations(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus AssignCellContainerClearance(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_AssignCellContainerClearance_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus AssignCellMfgOrderClearance(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ClearCompletedTasks(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus Execute_Move_Specific(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus FreezeFromState(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_LoadESigDetails_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ProcessElectronicProceduresPreMove(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus RejectNonconformingMtl(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus UpdateFromStepPass(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus UpdateToStepPass(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidateCellContainerClearance(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_ValidateCellContainerClearance_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidateCellMfgOrderClearance(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidateContainerInProcess(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePath(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePathToStepExists(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Parameters parameters,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveTxnMethod[] methods,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveTxn moveTxn,
      MoveTxn_Request request,
      out MoveTxn_Result result);
  }
}
