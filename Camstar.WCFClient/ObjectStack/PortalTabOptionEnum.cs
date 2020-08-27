// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalTabOptionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PortalTabOptionEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052804, false, false, false, "0"), Enumeration("0")] Inherit,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052676, false, false, false, "1"), Enumeration("1")] NewTab,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052675, false, false, false, "2"), EnumMember, Enumeration("2")] SpecifiedTab,
  }
}
