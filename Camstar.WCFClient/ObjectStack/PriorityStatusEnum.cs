// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PriorityStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PriorityStatusEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1053056, false, false, false, "1")] FutureDue = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050722, false, false, false, "2"), EnumMember, Enumeration("2")] PastDue = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053055, false, false, false, "3"), EnumMember, Enumeration("3")] NowDue = 3,
  }
}
