// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DispatchTypeEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050381, false, false, false, "1"), EnumMember] Order = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050382, false, false, false, "2")] ContainerMoveIn = 2,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050383, false, false, false, "3"), Enumeration("3"), EnumMember] ContainerMoveOut = 3,
    [EnumMember, Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051844, false, false, false, "4")] BatchOrder = 4,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779318, false, false, false, "5"), Enumeration("5"), EnumMember] EProcedure = 5,
  }
}
