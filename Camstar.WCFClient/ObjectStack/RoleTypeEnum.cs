// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum RoleTypeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778924, false, false, false, "1"), EnumMember, Enumeration("1")] Shopfloor = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778923, false, false, false, "2"), Enumeration("2"), EnumMember] Quality = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778657, false, false, false, "3"), EnumMember] ChangeManagement = 3,
  }
}
