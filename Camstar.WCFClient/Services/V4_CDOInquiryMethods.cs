// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_CDOInquiryMethods
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
  public enum V4_CDOInquiryMethods
  {
    [Enumeration(null), EnumMember] CDOInquiry_GetAllCDODefs,
    [Enumeration(null), EnumMember] CDOInquiry_GetCDOs,
    [Enumeration(null), EnumMember] CDOInquiry_GetFields,
    [EnumMember, Enumeration(null)] CDOInquiry_GetInstances,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
