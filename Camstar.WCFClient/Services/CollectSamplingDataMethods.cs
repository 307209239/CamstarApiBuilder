﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectSamplingDataMethods
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
  public enum CollectSamplingDataMethods
  {
    [Enumeration(null), EnumMember] CollectSampling_ChangeQty,
    [EnumMember, Enumeration(null)] CollectSampling_Execution,
    [Enumeration(null), EnumMember] CollectSampling_ProductionEvent,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
