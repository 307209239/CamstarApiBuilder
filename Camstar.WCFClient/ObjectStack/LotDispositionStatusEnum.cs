// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotDispositionStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum LotDispositionStatusEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052045, false, false, false, "1"), EnumMember, Enumeration("1")] NoneAssigned = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052046, false, false, false, "2"), EnumMember] Assigned = 2,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1048801, false, false, false, "3")] InProcess = 3,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051842, false, false, false, "4"), Enumeration("4"), EnumMember] Complete = 4,
  }
}
