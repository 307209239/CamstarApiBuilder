﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BillMaintMethods
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
  public enum BillMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [Enumeration(null), EnumMember] DeleteAllRevisions,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] NewRev,
    [Enumeration(null), EnumMember] NewRevCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] SaveAsRev,
    [Enumeration(null), EnumMember] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
