// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DayOfWeekEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DayOfWeekEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050651, false, false, false, "1"), EnumMember] Sunday = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050649, false, false, false, "2"), Enumeration("2"), EnumMember] Monday = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050653, false, false, false, "3"), EnumMember] Tuesday = 3,
    [Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050654, false, false, false, "4"), EnumMember] Wednesday = 4,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050652, false, false, false, "5"), Enumeration("5"), EnumMember] Thursday = 5,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050648, false, false, false, "6"), Enumeration("6")] Friday = 6,
    [EnumMember, Enumeration("7"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050650, false, false, false, "7")] Saturday = 7,
  }
}
