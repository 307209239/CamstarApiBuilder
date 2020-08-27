// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MonthEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum MonthEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050659, false, false, false, "1"), EnumMember, Enumeration("1")] January = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050658, false, false, false, "2"), EnumMember] February = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050662, false, false, false, "3"), Enumeration("3")] March = 3,
    [Enumeration("4"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050655, false, false, false, "4")] April = 4,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050663, false, false, false, "5"), Enumeration("5")] May = 5,
    [EnumMember, Enumeration("6"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050661, false, false, false, "6")] June = 6,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050660, false, false, false, "7"), EnumMember, Enumeration("7")] July = 7,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050656, false, false, false, "8"), Enumeration("8")] August = 8,
    [Enumeration("9"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050666, false, false, false, "9"), EnumMember] September = 9,
    [Enumeration("10"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050665, false, false, false, "10"), EnumMember] October = 10, // 0x0000000A
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050664, false, false, false, "11"), EnumMember, Enumeration("11")] November = 11, // 0x0000000B
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050657, false, false, false, "12"), EnumMember, Enumeration("12")] December = 12, // 0x0000000C
  }
}
