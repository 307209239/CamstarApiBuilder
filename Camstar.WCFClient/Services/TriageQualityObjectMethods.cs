﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TriageQualityObjectMethods
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
  public enum TriageQualityObjectMethods
  {
    [EnumMember, Enumeration(null)] AssignChecklist,
    [EnumMember, Enumeration(null)] AssignProcessModel,
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetTriageSpecDetail,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] SetEscalationDate,
    [Enumeration(null), EnumMember] SetTriageComplete,
    [Enumeration(null), EnumMember] ValidateCategoryTransition,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
