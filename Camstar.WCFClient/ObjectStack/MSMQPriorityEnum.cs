// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MSMQPriorityEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum MSMQPriorityEnum
  {
    [Metadata("Generic String", "", false, false, true, "String", 1050008, false, false, false, "Lowest"), EnumMember, Enumeration("Lowest")] Lowest = -1831422828, // 0x92D6B494
    [Metadata("Generic String", "", false, false, true, "String", 1050012, false, false, false, "AboveNormal"), EnumMember, Enumeration("AboveNormal")] AboveNormal = -1384254116, // 0xAD7DF55C
    [EnumMember, Metadata("Generic String", "", false, false, true, "String", 1050017, false, false, false, "VeryHigh"), Enumeration("VeryHigh")] VeryHigh = -1011156858, // 0xC3BAF886
    [Metadata("Generic String", "", false, false, true, "String", 1050013, false, false, false, "High"), EnumMember, Enumeration("High")] High = -77932258, // 0xFB5AD91E
    [Metadata("Generic String", "", false, false, true, "String", 1050009, false, false, false, "VeryLow"), EnumMember, Enumeration("VeryLow")] VeryLow = 643254184, // 0x265747A8
    [Enumeration("Low"), Metadata("Generic String", "", false, false, true, "String", 1050010, false, false, false, "Low"), EnumMember] Low = 1502599728, // 0x598FDA30
    [Metadata("Generic String", "", false, false, true, "String", 1050011, false, false, false, "Normal"), EnumMember, Enumeration("Normal")] Normal = 1690472495, // 0x64C2902F
    [EnumMember, Metadata("Generic String", "", false, false, true, "String", 1050014, false, false, false, "Highest"), Enumeration("Highest")] Highest = 1884810286, // 0x7057EC2E
  }
}
