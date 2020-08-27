// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportDetailStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ExportImportDetailStatusEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050506, false, false, false, "0"), Enumeration("0")] None,
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050803, false, false, false, "1"), EnumMember] Succeeded,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050804, false, false, false, "2"), EnumMember, Enumeration("2")] Failed,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050805, false, false, false, "3")] Skipped,
  }
}
