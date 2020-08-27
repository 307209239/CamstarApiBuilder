// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResponseLayoutCtrlEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ResponseLayoutCtrlEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052391, false, false, false, "1"), Enumeration("1"), EnumMember] BelowHorizontal = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052392, false, false, false, "2"), EnumMember, Enumeration("2")] BelowVertical = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052393, false, false, false, "3"), Enumeration("3"), EnumMember] Right = 3,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052394, false, false, false, "4"), Enumeration("4"), EnumMember] Left = 4,
  }
}
