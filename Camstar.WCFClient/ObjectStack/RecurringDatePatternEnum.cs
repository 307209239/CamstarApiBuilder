// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDatePatternEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum RecurringDatePatternEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051240, false, false, false, "0"), Enumeration("0"), EnumMember] Once,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050668, false, false, false, "1"), EnumMember, Enumeration("1")] Daily,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050670, false, false, false, "2")] Weekly,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050669, false, false, false, "3"), Enumeration("3")] Monthly,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050671, false, false, false, "4"), EnumMember, Enumeration("4")] Yearly,
    [Enumeration("5"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16778042, false, false, false, "5")] Hourly,
  }
}
