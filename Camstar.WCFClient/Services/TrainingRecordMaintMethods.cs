﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingRecordMaintMethods
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
  public enum TrainingRecordMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [Enumeration(null), EnumMember] Freeze,
    [Enumeration(null), EnumMember] GetTrainingRecord,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [Enumeration(null), EnumMember] NewCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [Enumeration(null), EnumMember] ValidateEmployeeRoleCombination,
    [EnumMember, Enumeration(null)] ValidateESigRequirement,
    [Enumeration(null), EnumMember] ValidateRefInfoIsUnique,
    [Enumeration(null), EnumMember] ValidateTrainer,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}