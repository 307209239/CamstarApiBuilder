// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportActionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ImportActionEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050810, false, false, false, "1")] Abort = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050811, false, false, false, "2"), Enumeration("2")] Skip = 2,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050812, false, false, false, "3"), Enumeration("3"), EnumMember] Overwrite = 3,
  }
}
