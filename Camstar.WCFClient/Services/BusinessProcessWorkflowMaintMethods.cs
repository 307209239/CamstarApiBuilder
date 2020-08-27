// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessProcessWorkflowMaintMethods
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
  public enum BusinessProcessWorkflowMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [EnumMember, Enumeration(null)] DeleteAllRevisions,
    [Enumeration(null), EnumMember] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] NewCopy,
    [Enumeration(null), EnumMember] NewRev,
    [EnumMember, Enumeration(null)] NewRevCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [Enumeration(null), EnumMember] SaveAsRev,
    [EnumMember, Enumeration(null)] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
