﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecordDecisionTreeMethods
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
  public enum RecordDecisionTreeMethods
  {
    [Enumeration(null), EnumMember] CreateParametricData,
    [Enumeration(null), EnumMember] GetActions,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}