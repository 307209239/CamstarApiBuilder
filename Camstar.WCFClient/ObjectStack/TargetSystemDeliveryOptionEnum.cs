// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemDeliveryOptionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TargetSystemDeliveryOptionEnum
  {
    [Enumeration("0"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050506, false, false, false, "0"), EnumMember] None = 0,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053210, false, false, false, "1"), Enumeration("1"), EnumMember] Folder = 1,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1053212, false, false, false, "3"), EnumMember] Database = 3,
    [Enumeration("4"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051301, false, false, false, "4")] Other = 4,
  }
}
