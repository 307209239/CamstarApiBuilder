// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionRangeColorEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DPCollectionRangeColorEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052451, false, false, false, "-2"), Enumeration("-2")] BelowOuter = -2, // 0xFFFFFFFE
    [Enumeration("-1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052452, false, false, false, "-1"), EnumMember] BelowInner = -1, // 0xFFFFFFFF
    [Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052453, false, false, false, "0"), EnumMember] WithinInner = 0,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052454, false, false, false, "1"), EnumMember, Enumeration("1")] AboveInner = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052455, false, false, false, "2"), Enumeration("2"), EnumMember] AboveOuter = 2,
  }
}
