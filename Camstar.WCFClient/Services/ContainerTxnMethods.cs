// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxnMethods
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ContainerTxnMethods
  {
    [Enumeration(null), EnumMember] AddAffectedContainerToEvent,
    [Enumeration(null), EnumMember] AddChildEventsToParentContainer,
    [EnumMember, Enumeration(null)] AddParentEventsToChildContainers,
    [Enumeration(null), EnumMember] AffectContainersToEvents,
    [EnumMember, Enumeration(null)] CheckQtyIssued,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] CreatePTHistory,
    [Enumeration(null), EnumMember] EnforceMaterialConsumptionCheck,
    [EnumMember, Enumeration(null)] ExecuteProcessTimerDisposition,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetAllIssueDetails,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetIssueDetails,
    [Enumeration(null), EnumMember] GetOwnerRole_ForPTProdEvent,
    [EnumMember, Enumeration(null)] GetProductFamilyTrainingRequirements,
    [Enumeration(null), EnumMember] GetProductTrainingRequirements,
    [EnumMember, Enumeration(null)] GetResourceTrainingRequirements,
    [Enumeration(null), EnumMember] GetSpecTrainingRequirements,
    [EnumMember, Enumeration(null)] GetStopTimersWithESig,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] MapLastActivityToContainer,
    [Enumeration(null), EnumMember] MapLastMoveDate,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ProcessSpecBusinessRule,
    [Enumeration(null), EnumMember] ProcessStopTimer,
    [Enumeration(null), EnumMember] ProcessTimerDisposition,
    [Enumeration(null), EnumMember] ProcessTimersESignatures,
    [EnumMember, Enumeration(null)] ResolveDataCollectionDef,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] SaveContainerDetail,
    [EnumMember, Enumeration(null)] SetESigProcessTimerDetails,
    [EnumMember, Enumeration(null)] SetSpecInContainer,
    [Enumeration(null), EnumMember] StartTimers,
    [Enumeration(null), EnumMember] StartTransactionTaskTimers,
    [EnumMember, Enumeration(null)] StopTimers,
    [Enumeration(null), EnumMember] ValidateAllowedTxnChildContainers,
    [EnumMember, Enumeration(null)] ValidateAllowedTxnParentContainer,
    [Enumeration(null), EnumMember] ValidateAllowedTxns,
    [EnumMember, Enumeration(null)] ValidateContainerStatus,
    [Enumeration(null), EnumMember] ValidateSpecTimers,
    [Enumeration(null), EnumMember] ValidateStopTimersESigRequirements,
    [Enumeration(null), EnumMember] ValidateTimers,
    [EnumMember, Enumeration(null)] ValidateTransactionTaskTimers,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
