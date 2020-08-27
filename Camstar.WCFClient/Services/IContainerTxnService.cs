// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerTxnService
  {
    [OperationContract]
    ResultStatus AddAffectedContainerToEvent(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_AddAffectedContainerToEvent_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus AddChildEventsToParentContainer(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus AddParentEventsToChildContainers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus AffectContainersToEvents(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus CheckQtyIssued(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_CheckQtyIssued_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus CreatePTHistory(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_CreatePTHistory_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus EnforceMaterialConsumptionCheck(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteProcessTimerDisposition(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetAllIssueDetails(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetIssueDetails(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetOwnerRole_ForPTProdEvent(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_GetOwnerRole_ForPTProdEvent_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetProductFamilyTrainingRequirements(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetProductTrainingRequirements(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetResourceTrainingRequirements(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetSpecTrainingRequirements(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetStopTimersWithESig(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_LoadESigDetails_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus MapLastActivityToContainer(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus MapLastMoveDate(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ProcessSpecBusinessRule(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_ProcessSpecBusinessRule_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ProcessStopTimer(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_ProcessStopTimer_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ProcessTimerDisposition(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_ProcessTimerDisposition_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ProcessTimersESignatures(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ResolveDataCollectionDef(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus SaveContainerDetail(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus SetESigProcessTimerDetails(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_SetESigProcessTimerDetails_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus SetSpecInContainer(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus StartTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus StartTransactionTaskTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus StopTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateAllowedTxnChildContainers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateAllowedTxnParentContainer(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateAllowedTxns(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateContainerStatus(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateSpecTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateStopTimersESigRequirements(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ValidateTransactionTaskTimers(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerTxnMethod[] methods,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result);
  }
}
