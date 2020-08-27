// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum QualityStatusEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049952, false, false, false, "1"), Enumeration("1"), EnumMember] Active = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050762, false, false, false, "2"), Enumeration("2"), EnumMember] Pending = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051202, false, false, false, "3")] Escalated = 3,
    [Enumeration("5"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1049398, false, false, false, "5")] Closed = 5,
    [Enumeration("6"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1049954, false, false, false, "6")] Deleted = 6,
    [Enumeration("7"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051293, false, false, false, "7"), EnumMember] Initiated = 7,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051367, false, false, false, "8"), EnumMember, Enumeration("8")] InReview = 8,
  }
}
