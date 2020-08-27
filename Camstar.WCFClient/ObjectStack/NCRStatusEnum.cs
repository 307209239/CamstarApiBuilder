// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum NCRStatusEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050430, false, false, false, "1"), Enumeration("1")] Open = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1049398, false, false, false, "2")] Closed = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051202, false, false, false, "3")] Escalated = 3,
  }
}
