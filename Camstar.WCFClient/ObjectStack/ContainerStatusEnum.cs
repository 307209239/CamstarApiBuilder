// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ContainerStatusEnum
  {
    [Enumeration("0"), Metadata("Generic Integer", "", false, false, true, "Integer", 1049954, false, false, false, "0"), EnumMember] Deleted,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1049952, false, false, false, "1"), Enumeration("1")] Active,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1049398, false, false, false, "2"), EnumMember] Closed,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048979, false, false, false, "3"), Enumeration("3"), EnumMember] InTransit,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049955, false, false, false, "4"), Enumeration("4"), EnumMember] IssuedComponent,
  }
}
