// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ClearanceLevelEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ClearanceLevelEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050506, false, false, false, "1"), EnumMember, Enumeration("1")] None = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049043, false, false, false, "2"), Enumeration("2"), EnumMember] Container = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1048810, false, false, false, "3"), Enumeration("3")] MfgOrder = 3,
  }
}
