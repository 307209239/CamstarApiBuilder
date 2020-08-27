// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubClassificationEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum SubClassificationEnum
  {
    [EnumMember, Enumeration("1"), Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1051096, false, false, false, "1")] Acceptance = 1,
    [Enumeration("2"), EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1051097, false, false, false, "2")] Monitoring = 2,
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1051098, false, false, false, "3"), EnumMember, Enumeration("3")] Calibration = 3,
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1051278, false, false, false, "4"), EnumMember, Enumeration("4")] FieldEvent = 4,
    [EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1051358, false, false, false, "5"), Enumeration("5")] General = 5,
    [EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052271, false, false, false, "6"), Enumeration("6")] Supplier = 6,
    [EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052272, false, false, false, "7"), Enumeration("7")] Incident = 7,
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052273, false, false, false, "8"), EnumMember, Enumeration("8")] Observation = 8,
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052274, false, false, false, "9"), EnumMember, Enumeration("9")] ManagementReview = 9,
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052275, false, false, false, "10"), EnumMember, Enumeration("10")] Environment = 10, // 0x0000000A
    [EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052276, false, false, false, "11"), Enumeration("11")] Health = 11, // 0x0000000B
    [Enumeration("12"), EnumMember, Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052277, false, false, false, "12")] Safety = 12, // 0x0000000C
  }
}
