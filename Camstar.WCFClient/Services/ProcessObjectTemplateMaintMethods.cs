// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTemplateMaintMethods
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
  public enum ProcessObjectTemplateMaintMethods
  {
    [EnumMember, Enumeration(null)] AddBusinessRule,
    [Enumeration(null), EnumMember] CheckChecklist,
    [Enumeration(null), EnumMember] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [EnumMember, Enumeration(null)] GetApprovalSheetTemplate,
    [Enumeration(null), EnumMember] GetOrganization,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadBusinessRules,
    [EnumMember, Enumeration(null)] LoadChecklistTemplate,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [Enumeration(null), EnumMember] NewCopy,
    [Enumeration(null), EnumMember] PostLoad_Sheet,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [Enumeration(null), EnumMember] RefreshApprovalSheet,
    [EnumMember, Enumeration(null)] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] ValidateEmployeeRoleCombination,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
