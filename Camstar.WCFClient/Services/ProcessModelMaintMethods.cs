// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessModelMaintMethods
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
  public enum ProcessModelMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadBusinessRules,
    [EnumMember, Enumeration(null)] LoadChecklistTemplate,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] LoadTemplate,
    [EnumMember, Enumeration(null)] New,
    [Enumeration(null), EnumMember] NewCopy,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [EnumMember, Enumeration(null)] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [Enumeration(null), EnumMember] ValidateStageOnAdd,
    [Enumeration(null), EnumMember] ValidateStageOnDelete,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
