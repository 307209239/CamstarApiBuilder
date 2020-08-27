// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BooleanThreeStateEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum BooleanThreeStateEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052993, false, false, false, "0"), Enumeration("0"), EnumMember] NotSet,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051303, false, false, false, "1"), Enumeration("1")] No,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051304, false, false, false, "2"), EnumMember] Yes,
  }
}
