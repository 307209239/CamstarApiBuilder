// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContentActionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ContentActionEnum
  {
    [Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052342, false, false, false, "10"), Enumeration("10"), EnumMember] CheckOut = 10, // 0x0000000A
    [Enumeration("20"), Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052341, false, false, false, "20"), EnumMember] CheckIn = 20, // 0x00000014
    [Enumeration("30"), Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052344, false, false, false, "30"), EnumMember] Publish = 30, // 0x0000001E
    [Enumeration("35"), Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052345, false, false, false, "35"), EnumMember] PublishAndClear = 35, // 0x00000023
    [EnumMember, Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052346, false, false, false, "40"), Enumeration("40")] Rollback = 40, // 0x00000028
    [Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, true, "Integer", 1052343, false, false, false, "50"), EnumMember, Enumeration("50")] Distribute = 50, // 0x00000032
  }
}
