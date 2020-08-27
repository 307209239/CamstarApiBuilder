// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TextVariableTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TextVariableTypeEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051358, false, false, false, "1")] General = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1053094, false, false, false, "2"), EnumMember] WIPMessage = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1053092, false, false, false, "3"), Enumeration("3")] AlarmMessage = 3,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053093, false, false, false, "4"), Enumeration("4"), EnumMember] InstructionText = 4,
  }
}
