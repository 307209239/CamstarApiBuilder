// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StartMethods
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
  public enum StartMethods
  {
    [EnumMember, Enumeration(null)] AttachCarrier,
    [Enumeration(null), EnumMember] ContainerTxn_Validations,
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [EnumMember, Enumeration(null)] GetTransactionWIPMsgs,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessChildAutoNumber,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] ProcessOnlyChildAutoNumber,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] Sampling_StartSetupSampling,
    [EnumMember, Enumeration(null)] SetWFStack,
    [Enumeration(null), EnumMember] ShopFloor_ApplyDetails,
    [Enumeration(null), EnumMember] ValidateCarrier,
    [EnumMember, Enumeration(null)] ValidateResource,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
