// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PermissionEnum
  {
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050470, false, false, false, "1"), EnumMember, Enumeration("1")] Allow = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050471, false, false, false, "2")] Disallow = 2,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050893, false, false, false, "3")] AllowWithESig = 3,
  }
}
