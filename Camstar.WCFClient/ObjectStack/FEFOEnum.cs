// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FEFOEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum FEFOEnum
  {
    [EnumMember, Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051822, false, false, false, "0")] NotEnforced,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051823, false, false, false, "1"), EnumMember, Enumeration("1")] Enforced,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051824, false, false, false, "2"), Enumeration("2"), EnumMember] Warn,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051825, false, false, false, "3"), Enumeration("3"), EnumMember] WarnWithESig,
  }
}
