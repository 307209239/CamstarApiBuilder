// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStateEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ResourceStateEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", true, false, false, "Integer", 1052843, false, false, false, "1")] NonscheduledTime = 1,
    [EnumMember, Metadata("Generic Integer", "", true, false, false, "Integer", 1052847, false, false, false, "2"), Enumeration("2")] UnscheduledDowntime = 2,
    [Metadata("Generic Integer", "", true, false, false, "Integer", 1052845, false, false, false, "3"), Enumeration("3"), EnumMember] ScheduledDowntime = 3,
    [Metadata("Generic Integer", "", true, false, false, "Integer", 1052842, false, false, false, "4"), Enumeration("4"), EnumMember] EngineeringTime = 4,
    [Enumeration("5"), EnumMember, Metadata("Generic Integer", "", true, false, false, "Integer", 1052844, false, false, false, "5")] ProductiveTime = 5,
    [EnumMember, Metadata("Generic Integer", "", true, false, false, "Integer", 1052846, false, false, false, "6"), Enumeration("6")] StandbyTime = 6,
  }
}
