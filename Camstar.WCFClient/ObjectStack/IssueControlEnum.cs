// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueControlEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum IssueControlEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050035, false, false, false, "1"), EnumMember, Enumeration("1")] Serialized = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050036, false, false, false, "2"), Enumeration("2")] Bulk = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050037, false, false, false, "3"), EnumMember, Enumeration("3")] LotAndStockPoint = 3,
    [Enumeration("4"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050038, false, false, false, "4")] StockPointOnly = 4,
    [EnumMember, Enumeration("5"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050039, false, false, false, "5")] NoTracking = 5,
    [Enumeration("6"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050040, false, false, false, "6"), EnumMember] CommentOnly = 6,
  }
}
