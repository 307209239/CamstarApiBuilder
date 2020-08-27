// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceMethods
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
  public enum MaintenanceMethods
  {
    [Enumeration(null), EnumMember] AddMassUpdateStatement,
    [Enumeration(null), EnumMember] AssignChangePackage,
    [EnumMember, Enumeration(null)] AuthorizeSigner,
    [Enumeration(null), EnumMember] Delete,
    [Enumeration(null), EnumMember] DeleteAllRevisions,
    [EnumMember, Enumeration(null)] Execute,
    [Enumeration(null), EnumMember] ExecuteAdd,
    [Enumeration(null), EnumMember] ExecuteAddRev,
    [EnumMember, Enumeration(null)] ExecuteChange,
    [EnumMember, Enumeration(null)] ExecuteDelete,
    [Enumeration(null), EnumMember] ExecuteDeleteAll,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetESigRequirements,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] NewCopy,
    [EnumMember, Enumeration(null)] PostLoad,
    [Enumeration(null), EnumMember] PostLoad_User,
    [Enumeration(null), EnumMember] PostSave,
    [EnumMember, Enumeration(null)] PostSave_User,
    [Enumeration(null), EnumMember] ProcessElectronicSignatures,
    [Enumeration(null), EnumMember] RemoveChangePackages,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] SetChangeHistory,
    [EnumMember, Enumeration(null)] SetCompletionMessage,
    [Enumeration(null), EnumMember] Sync,
    [EnumMember, Enumeration(null)] UnFreeze,
    [Enumeration(null), EnumMember] ValidateAdd,
    [Enumeration(null), EnumMember] ValidateAddRev,
    [Enumeration(null), EnumMember] ValidateChange,
    [EnumMember, Enumeration(null)] ValidateDelete,
    [EnumMember, Enumeration(null)] ValidateDeleteAll,
    [EnumMember, Enumeration(null)] ValidateElectronicSignatures,
    [Enumeration(null), EnumMember] VerifyPasswordSignature,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
