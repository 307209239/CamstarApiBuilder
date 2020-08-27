// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectMaintMethods
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
  public enum ProcessObjectMaintMethods
  {
    [Enumeration(null), EnumMember] AddBusinessRule,
    [EnumMember, Enumeration(null)] CheckChecklist,
    [EnumMember, Enumeration(null)] CheckDataPointCollection,
    [EnumMember, Enumeration(null)] CreateStructureChanges,
    [Enumeration(null), EnumMember] Delete,
    [Enumeration(null), EnumMember] Freeze,
    [Enumeration(null), EnumMember] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetOrganization,
    [Enumeration(null), EnumMember] GetParentDataObjectStage,
    [EnumMember, Enumeration(null)] GetPrerequisites,
    [EnumMember, Enumeration(null)] GetStructureToChange,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadBusinessRules,
    [EnumMember, Enumeration(null)] LoadChecklistTemplate,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] LoadTemplate,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] NewCopy,
    [Enumeration(null), EnumMember] PostLoad_Sheet,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [Enumeration(null), EnumMember] RefreshApprovalSheet,
    [Enumeration(null), EnumMember] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] ValidateEmployeeRoleCombination,
    [EnumMember, Enumeration(null)] ValidatePermissions,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
