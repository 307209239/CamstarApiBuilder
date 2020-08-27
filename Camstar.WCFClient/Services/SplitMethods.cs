// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SplitMethods
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
  public enum SplitMethods
  {
    [EnumMember, Enumeration(null)] CreateParametricData,
    [EnumMember, Enumeration(null)] ExecuteContainerSplit,
    [EnumMember, Enumeration(null)] ExecuteMaterialSplit,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetContainerName,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessAutoNumbering,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [EnumMember, Enumeration(null)] SetTxnXRefsToAncestors,
    [EnumMember, Enumeration(null)] SplitContainer,
    [EnumMember, Enumeration(null)] SplitMaterial,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
