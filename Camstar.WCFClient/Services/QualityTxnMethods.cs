// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QualityTxnMethods
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
  public enum QualityTxnMethods
  {
    [Enumeration(null), EnumMember] AddAction,
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetOrganization,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] InitializeProcessObjectActions,
    [Enumeration(null), EnumMember] InitializeProcessObjectActions_User,
    [EnumMember, Enumeration(null)] InitializeQualityObjectActions,
    [Enumeration(null), EnumMember] InitializeQualityObjectActions_User,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] RemoveAction,
    [Enumeration(null), EnumMember] ResolveDataCollectionDef,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [EnumMember, Enumeration(null)] ValidateApprovalStatus,
    [Enumeration(null), EnumMember] ValidateAvailable,
    [EnumMember, Enumeration(null)] ValidateEmployeeRoleCombination,
    [Enumeration(null), EnumMember] ValidateOwnerAssigned,
    [Enumeration(null), EnumMember] ValidatePendingStatus,
    [Enumeration(null), EnumMember] ValidatePermissions,
    [EnumMember, Enumeration(null)] ValidateQualityObjectStatus,
    [EnumMember, Enumeration(null)] ValidateUserAccess,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
