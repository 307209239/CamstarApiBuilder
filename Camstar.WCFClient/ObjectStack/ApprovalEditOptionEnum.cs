// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalEditOptionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ApprovalEditOptionEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051972, false, false, false, "1"), Enumeration("1"), EnumMember] RoleAndName = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1048681, false, false, false, "2")] Name = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050506, false, false, false, "3"), Enumeration("3"), EnumMember] None = 3,
  }
}
