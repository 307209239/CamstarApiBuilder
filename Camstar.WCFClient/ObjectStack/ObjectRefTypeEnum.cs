// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectRefTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ObjectRefTypeEnum
  {
    [Camstar.WCF.ObjectStack.Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050568, false, false, false, "1"), EnumMember] NDO = 1,
    [Camstar.WCF.ObjectStack.Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050569, false, false, false, "2"), EnumMember] RDO = 2,
    [Camstar.WCF.ObjectStack.Enumeration("5"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050870, false, false, false, "5")] Enumeration = 5,
  }
}
