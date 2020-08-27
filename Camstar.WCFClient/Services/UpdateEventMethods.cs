// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventMethods
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
  public enum UpdateEventMethods
  {
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] ExecuteChecklist,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetApprovalSheetDetails,
    [Enumeration(null), EnumMember] GetApprovalSheetTemplate,
    [Enumeration(null), EnumMember] GetChecklistEntries,
    [EnumMember, Enumeration(null)] GetCrossRefDetails,
    [Enumeration(null), EnumMember] GetCrossReferences,
    [Enumeration(null), EnumMember] GetDataPoints,
    [EnumMember, Enumeration(null)] GetDetails,
    [EnumMember, Enumeration(null)] GetEventDetails,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] SaveApprovalSheet,
    [Enumeration(null), EnumMember] SaveCrossReferences,
    [EnumMember, Enumeration(null)] SubmitEvent,
    [Enumeration(null), EnumMember] ValidateEvent,
    [Enumeration(null), EnumMember] ValidateIfChecklistHasResponses,
    [EnumMember, Enumeration(null)] ValidateOwner,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
