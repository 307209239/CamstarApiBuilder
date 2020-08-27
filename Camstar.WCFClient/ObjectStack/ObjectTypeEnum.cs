// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ObjectTypeEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050879, false, false, false, "0"), Enumeration("0")] NDO,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777538, false, false, false, "1"), Enumeration("1"), EnumMember] RDO,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049043, false, false, false, "2"), EnumMember, Enumeration("2")] Container,
  }
}
