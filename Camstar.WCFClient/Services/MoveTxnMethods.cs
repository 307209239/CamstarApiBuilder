// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveTxnMethods
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
  public enum MoveTxnMethods
  {
    [EnumMember, Enumeration(null)] AdditionalValidations,
    [EnumMember, Enumeration(null)] AssignCellContainerClearance,
    [EnumMember, Enumeration(null)] AssignCellMfgOrderClearance,
    [EnumMember, Enumeration(null)] ClearCompletedTasks,
    [Enumeration(null), EnumMember] CreateParametricData,
    [Enumeration(null), EnumMember] Execute_Move_Specific,
    [EnumMember, Enumeration(null)] FreezeFromState,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] ProcessElectronicProceduresPreMove,
    [Enumeration(null), EnumMember] RejectNonconformingMtl,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] UpdateFromStepPass,
    [EnumMember, Enumeration(null)] UpdateToStepPass,
    [EnumMember, Enumeration(null)] ValidateCellContainerClearance,
    [Enumeration(null), EnumMember] ValidateCellMfgOrderClearance,
    [Enumeration(null), EnumMember] ValidateContainerInProcess,
    [EnumMember, Enumeration(null)] ValidatePath,
    [EnumMember, Enumeration(null)] ValidatePathToStepExists,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
