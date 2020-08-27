// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleHolderTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum BizRuleHolderTypeEnum
  {
    [EnumMember, Enumeration("1040"), Metadata("CDOType", "", false, false, false, "Integer", 1049043, false, false, false, "1040")] Container = 1040, // 0x00000410
    [Metadata("CDOType", "", false, false, false, "Integer", 1048861, false, false, false, "1140"), EnumMember, Enumeration("1140")] Employee = 1140, // 0x00000474
    [Enumeration("1250"), Metadata("CDOType", "", false, false, false, "Integer", 1048659, false, false, false, "1250"), EnumMember] Factory = 1250, // 0x000004E2
    [Enumeration("7487"), Metadata("CDOType", "", false, false, false, "Integer", 1051419, false, false, false, "7487"), EnumMember] QualityObject = 7487, // 0x00001D3F
    [Enumeration("7489"), Metadata("CDOType", "", false, false, false, "Integer", 1051042, false, false, false, "7489"), EnumMember] Event = 7489, // 0x00001D41
    [EnumMember, Enumeration("8477"), Metadata("CDOType", "", false, false, false, "Integer", 1053240, false, false, false, "8477")] ChangePackage = 8477, // 0x0000211D
  }
}
