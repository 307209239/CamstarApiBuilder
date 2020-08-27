// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcObjectOutstandingDtlEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ProcObjectOutstandingDtlEnum
  {
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052201, false, false, false, "0"), Enumeration("0"), EnumMember] NoneOutstanding,
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052202, false, false, false, "1"), EnumMember] ProcessObjectsOutstanding,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052203, false, false, false, "2"), Enumeration("2")] LotsOutstanding,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052337, false, false, false, "3"), EnumMember, Enumeration("3")] LotsCompleted,
  }
}
