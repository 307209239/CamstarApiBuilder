// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InstructionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum InstructionTypeEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050561, false, false, false, "1"), Enumeration("1")] PassFail = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050562, false, false, false, "2")] DataCollection = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050563, false, false, false, "3"), EnumMember] Acknowledgement = 3,
  }
}
