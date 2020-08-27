// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceAuditTrailTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ResourceAuditTrailTypeEnum
  {
    [EnumMember, Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778933, false, false, false, "0")] AllTransactionTypes = 0,
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778915, false, false, false, "1")] ResourceTransactions = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778916, false, false, false, "2"), Enumeration("2"), EnumMember] ResourceRefTransactions = 2,
    [Enumeration("5"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 7276279, false, false, false, "5")] SelectTransactionTypes = 5,
  }
}
