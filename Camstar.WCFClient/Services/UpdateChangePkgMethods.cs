// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateChangePkgMethods
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
  public enum UpdateChangePkgMethods
  {
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] CreateSheet,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetApprovalSheetDetails,
    [EnumMember, Enumeration(null)] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadCollaboratorTemplate,
    [EnumMember, Enumeration(null)] LoadDefaultMessages,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [Enumeration(null), EnumMember] SaveApprovalSheet,
    [EnumMember, Enumeration(null)] SaveCollaboratorDetails,
    [Enumeration(null), EnumMember] SendEmailToCollaborators,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
