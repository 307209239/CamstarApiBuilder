﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecurringDateReqMaintMethods
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
  public enum RecurringDateReqMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [Enumeration(null), EnumMember] DeleteAllRevisions,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] NewCopy,
    [EnumMember, Enumeration(null)] NewRev,
    [Enumeration(null), EnumMember] NewRevCopy,
    [EnumMember, Enumeration(null)] SaveAs,
    [Enumeration(null), EnumMember] SaveAsRev,
    [EnumMember, Enumeration(null)] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
