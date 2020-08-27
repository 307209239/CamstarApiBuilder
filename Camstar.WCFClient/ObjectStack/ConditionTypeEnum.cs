// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ConditionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ConditionTypeEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052732, false, false, false, "1"), Enumeration("1")] Equal = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052733, false, false, false, "2")] NotEqual = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052734, false, false, false, "3"), Enumeration("3"), EnumMember] Contains = 3,
  }
}
