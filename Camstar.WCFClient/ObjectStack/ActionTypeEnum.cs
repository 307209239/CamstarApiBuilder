// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ActionTypeEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1049043, false, false, false, "1"), EnumMember] Container = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051298, false, false, false, "2"), EnumMember] QualityObject = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053240, false, false, false, "3"), EnumMember, Enumeration("3")] ChangePackage = 3,
  }
}
