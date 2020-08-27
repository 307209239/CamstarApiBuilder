// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyOperatorEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum QtyOperatorEnum
  {
    [Enumeration("10"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052894, false, false, false, "10")] Equal = 10, // 0x0000000A
    [Enumeration("20"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052758, false, false, false, "20")] GreaterThan = 20, // 0x00000014
    [EnumMember, Enumeration("30"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052759, false, false, false, "30")] GreaterThanOrEqual = 30, // 0x0000001E
    [EnumMember, Enumeration("40"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052760, false, false, false, "40")] LessThan = 40, // 0x00000028
    [EnumMember, Enumeration("50"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052761, false, false, false, "50")] LessThanOrEqual = 50, // 0x00000032
  }
}
