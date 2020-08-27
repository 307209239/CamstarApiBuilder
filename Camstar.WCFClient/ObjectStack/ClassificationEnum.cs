// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ClassificationEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ClassificationEnum
  {
    [Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1048625, false, false, false, "1"), EnumMember, Enumeration("1")] Product = 1,
    [Enumeration("2"), Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1051089, false, false, false, "2"), EnumMember] Process = 2,
    [EnumMember, Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1051358, false, false, false, "3"), Enumeration("3")] General = 3,
    [Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1052269, false, false, false, "4"), EnumMember, Enumeration("4")] Audit = 4,
    [Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1052270, false, false, false, "5"), Enumeration("5"), EnumMember] EHandS = 5,
  }
}
