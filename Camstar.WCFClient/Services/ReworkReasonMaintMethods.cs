﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReworkReasonMaintMethods
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
  public enum ReworkReasonMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [Enumeration(null), EnumMember] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [Enumeration(null), EnumMember] NewCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}