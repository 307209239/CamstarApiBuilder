// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectSelValTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ObjectSelValTypeEnum
  {
    [EnumMember, Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050506, false, false, false, "0")] None,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050570, false, false, false, "1"), Enumeration("1")] Static,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050871, false, false, false, "2"), Enumeration("2")] Query,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050872, false, false, false, "3"), EnumMember] ListField,
    [EnumMember, Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050873, false, false, false, "4")] ObjectGroup,
  }
}
