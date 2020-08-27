// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryRecordTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum HistoryRecordTypeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051042, false, false, false, "1"), EnumMember, Enumeration("1")] Event = 1,
    [EnumMember, Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1049043, false, false, false, "4")] Container = 4,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051877, false, false, false, "5"), Enumeration("5"), EnumMember] ContainerInCarrier = 5,
  }
}
