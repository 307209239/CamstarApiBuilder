// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TimerCompletionStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TimerCompletionStatusEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778672, false, false, false, "1")] UnderMin = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051241, false, false, false, "2"), EnumMember] Successful = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778671, false, false, false, "3"), Enumeration("3"), EnumMember] OverMax = 3,
  }
}
