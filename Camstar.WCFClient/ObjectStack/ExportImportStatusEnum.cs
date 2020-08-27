// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ExportImportStatusEnum
  {
    [Enumeration("0"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050813, false, false, false, "0")] NotStarted,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1048801, false, false, false, "1"), Enumeration("1")] InProcess,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051842, false, false, false, "2"), EnumMember, Enumeration("2")] Completed,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050804, false, false, false, "3"), EnumMember, Enumeration("3")] Failed,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050815, false, false, false, "4"), Enumeration("4"), EnumMember] Cancelled,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050816, false, false, false, "5"), Enumeration("5")] FileGenerated,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050817, false, false, false, "6"), EnumMember, Enumeration("6")] FileDeleted,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049954, false, false, false, "7"), EnumMember, Enumeration("7")] Deleted,
    [EnumMember, Enumeration("8"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050818, false, false, false, "8")] FileGenerationInProgress,
    [EnumMember, Enumeration("9"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050819, false, false, false, "9")] FileUploadInProgress,
  }
}
