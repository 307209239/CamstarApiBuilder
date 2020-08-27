// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteProductionProcessMethods
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
  public enum ExecuteProductionProcessMethods
  {
    [EnumMember, Enumeration(null)] AddCompletedTask,
    [Enumeration(null), EnumMember] AssignCellContainerClearance,
    [EnumMember, Enumeration(null)] AssignCellMfgOrderClearance,
    [Enumeration(null), EnumMember] AssignStationContainerClearance,
    [EnumMember, Enumeration(null)] AssignStationMfgOrderClearance,
    [Enumeration(null), EnumMember] ClearStationContainerClearance,
    [Enumeration(null), EnumMember] ClearStationMfgOrderClearance,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] LoadProcessListDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [Enumeration(null), EnumMember] SetLastCompletedTask,
    [EnumMember, Enumeration(null)] UpdateCompletedTask,
    [EnumMember, Enumeration(null)] ValidateCellContainerClearance,
    [EnumMember, Enumeration(null)] ValidateCellMfgOrderClearance,
    [Enumeration(null), EnumMember] ValidateStationContainerClearance,
    [Enumeration(null), EnumMember] ValidateStationMfgOrderClearance,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
