﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierFamilyMaintMethods
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
  public enum CarrierFamilyMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [EnumMember, Enumeration(null)] SaveAs,
    [EnumMember, Enumeration(null)] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
