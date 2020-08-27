// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseTemplateMaintMethods
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
  public enum PhaseTemplateMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadBusinessRules,
    [Enumeration(null), EnumMember] LoadChecklistTemplate,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [Enumeration(null), EnumMember] NewCopy,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] UnFreeze,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
