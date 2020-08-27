// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DecisionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DecisionTypeEnum
  {
    [Enumeration("10"), Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, false, "Integer", 1051365, false, false, false, "10"), EnumMember] Approved = 10, // 0x0000000A
    [EnumMember, Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, false, "Integer", 1051368, false, false, false, "20"), Enumeration("20")] Rejected = 20, // 0x00000014
  }
}
