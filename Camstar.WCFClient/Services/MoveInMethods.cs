// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveInMethods
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
  public enum MoveInMethods
  {
    [EnumMember, Enumeration(null)] AssignCellContainerClearance,
    [Enumeration(null), EnumMember] AssignCellMfgOrderClearance,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] RejectNonconformingMtl,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] ValidateCellContainerClearance,
    [Enumeration(null), EnumMember] ValidateCellMfgOrderClearance,
    [EnumMember, Enumeration(null)] ValidateQueueTime,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
