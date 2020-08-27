// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeProcessMethods
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
  public enum ChangeProcessMethods
  {
    [Enumeration(null), EnumMember] AddBusinessRule,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] Delete,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetApprovalSheetTemplate,
    [Enumeration(null), EnumMember] GetChecklistEntries,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetOrganization,
    [Enumeration(null), EnumMember] GetPrerequisites,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadBusinessRules,
    [EnumMember, Enumeration(null)] LoadChecklistTemplate,
    [Enumeration(null), EnumMember] LoadDataPoints,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] PreviewChecklist,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] ReviewDataPoints,
    [Enumeration(null), EnumMember] SetTriageComplete,
    [Enumeration(null), EnumMember] ValidateProcessObject,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
