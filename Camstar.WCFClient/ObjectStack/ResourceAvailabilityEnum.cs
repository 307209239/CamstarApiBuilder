// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceAvailabilityEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ResourceAvailabilityEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1049956, false, false, false, "1")] Up = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1049957, false, false, false, "2"), Enumeration("2")] Down = 2,
  }
}
