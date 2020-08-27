// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPortalTabOptionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum UIPortalTabOptionEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1053004, false, false, false, "1"), Enumeration("1")] CurrentTab = 1,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053005, false, false, false, "2"), Enumeration("2"), EnumMember] NewTab = 2,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053006, false, false, false, "3"), EnumMember, Enumeration("3")] SpecifiedTab = 3,
  }
}
