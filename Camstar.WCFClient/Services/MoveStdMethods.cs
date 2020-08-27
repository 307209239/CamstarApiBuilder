// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveStdMethods
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
  public enum MoveStdMethods
  {
    [EnumMember, Enumeration(null)] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [Enumeration(null), EnumMember] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] MoveStd_LotSamplingValidations,
    [Enumeration(null), EnumMember] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] Sampling_MoveValidations,
    [EnumMember, Enumeration(null)] SamplingValidation,
    [Enumeration(null), EnumMember] ValidateEProcedure,
    [EnumMember, Enumeration(null)] ValidateTaskComplete,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
