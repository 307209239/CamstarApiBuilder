// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDisplayOptionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum SPCChartDisplayOptionEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1053032, false, false, false, "1")] DisplayOnlyOnException = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052616, false, false, false, "2"), Enumeration("2"), EnumMember] RunTimeDisplay = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053033, false, false, false, "3"), EnumMember, Enumeration("3")] NoChartNever = 3,
  }
}
