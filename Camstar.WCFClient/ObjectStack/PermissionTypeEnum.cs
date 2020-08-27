// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PermissionTypeEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1051568, false, false, false, null), Enumeration("")] PortalPageSecurity = -1013311339, // 0xC39A1895
    [Enumeration(""), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1051743, false, false, false, null)] PortalConfigurationSecurity = -559777184, // 0xDEA27A60
  }
}
