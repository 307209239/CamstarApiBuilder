// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RouteApprovalMethods
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
  public enum RouteApprovalMethods
  {
    [Enumeration(null), EnumMember] CreateApprover,
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] CreateSheet,
    [Enumeration(null), EnumMember] GetActions,
    [Enumeration(null), EnumMember] GetApprovalSheet,
    [EnumMember, Enumeration(null)] GetApprovalSheetDetails,
    [Enumeration(null), EnumMember] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
