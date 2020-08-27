// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DelegationStatusEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1049952, false, false, false, "1"), Enumeration("1")] Active = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778758, false, false, false, "2"), Enumeration("2"), EnumMember] Future = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051470, false, false, false, "3"), EnumMember] Expired = 3,
  }
}
