﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CloseCPStatusesMethods
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
  public enum CloseCPStatusesMethods
  {
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
