// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaborateStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum CollaborateStatusEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050762, false, false, false, "1"), EnumMember, Enumeration("1")] Pending = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778090, false, false, false, "2"), Enumeration("2"), EnumMember] Late = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051842, false, false, false, "3")] Complete = 3,
  }
}
