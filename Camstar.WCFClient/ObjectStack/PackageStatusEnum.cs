// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PackageStatusEnum
  {
    [Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 1049398, false, false, false, "0"), EnumMember] Closed,
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050430, false, false, false, "1")] Open,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778127, false, false, false, "2")] Deployed,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051368, false, false, false, "3")] Rejected,
    [Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051369, false, false, false, "4"), EnumMember] Voided,
  }
}
