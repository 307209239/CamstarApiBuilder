// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScheduledBizRuleStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ScheduledBizRuleStatusEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050762, false, false, false, "1"), EnumMember, Enumeration("1")] Pending = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1048801, false, false, false, "2")] InProcess = 2,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051239, false, false, false, "3")] OnHold = 3,
  }
}
