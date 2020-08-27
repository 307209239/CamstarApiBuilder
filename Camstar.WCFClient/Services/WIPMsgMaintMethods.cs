// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WIPMsgMaintMethods
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
  public enum WIPMsgMaintMethods
  {
    [EnumMember, Enumeration(null)] AddAllKeyDetail,
    [Enumeration(null), EnumMember] AddLabelDetail,
    [EnumMember, Enumeration(null)] AddOperationDetail,
    [Enumeration(null), EnumMember] ClearAllKey,
    [EnumMember, Enumeration(null)] Delete,
    [Enumeration(null), EnumMember] DeleteDetail,
    [EnumMember, Enumeration(null)] DeleteLabelKey,
    [Enumeration(null), EnumMember] DeleteOprKey,
    [EnumMember, Enumeration(null)] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadDetail,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] SaveAsAllDetail,
    [EnumMember, Enumeration(null)] SaveAsLabelDetail,
    [EnumMember, Enumeration(null)] SaveAsOperationDetail,
    [Enumeration(null), EnumMember] SaveDetail,
    [EnumMember, Enumeration(null)] SetCompletionMessageAdd,
    [EnumMember, Enumeration(null)] SetCompletionMessageChange,
    [Enumeration(null), EnumMember] SetCompletionMessageDelete,
    [Enumeration(null), EnumMember] SetCompletionMessageLoad,
    [Enumeration(null), EnumMember] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
