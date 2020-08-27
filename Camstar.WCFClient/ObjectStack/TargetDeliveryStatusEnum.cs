// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetDeliveryStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TargetDeliveryStatusEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1053261, false, false, false, "1")] Locked = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051842, false, false, false, "2")] Completed = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050804, false, false, false, "3"), EnumMember] Error = 3,
    [Enumeration("4"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052170, false, false, false, "4")] Reprocess = 4,
    [Enumeration("5"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050762, false, false, false, "5")] Pending = 5,
  }
}
