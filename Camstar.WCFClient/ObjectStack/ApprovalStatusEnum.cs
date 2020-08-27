// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ApprovalStatusEnum
  {
    [EnumMember, Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, false, "Integer", 1050762, false, false, false, "0"), Enumeration("0")] Pending = 0,
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, false, "Integer", 1051607, false, false, false, "10"), EnumMember, Enumeration("10")] Routed = 10, // 0x0000000A
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, false, "Integer", 1050815, false, false, false, "20"), EnumMember, Enumeration("20")] Cancelled = 20, // 0x00000014
    [Enumeration("30"), EnumMember, Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, false, "Integer", 1051368, false, false, false, "30")] Rejected = 30, // 0x0000001E
    [Enumeration("40"), EnumMember, Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, false, "Integer", 1051365, false, false, false, "40")] Approved = 40, // 0x00000028
  }
}
