// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignApprovalSheetMethods
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
  public enum AssignApprovalSheetMethods
  {
    [Enumeration(null), EnumMember] CreateParametricData,
    [Enumeration(null), EnumMember] CreateSheet,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetApprovalSheet,
    [Enumeration(null), EnumMember] GetApprovalSheetDetails,
    [EnumMember, Enumeration(null)] GetApprovalSheetTemplate,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
