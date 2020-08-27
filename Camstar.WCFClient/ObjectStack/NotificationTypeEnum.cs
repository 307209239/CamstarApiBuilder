// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum NotificationTypeEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051750, false, false, false, "1")] QualityRecOwnershipAssignment = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051755, false, false, false, "6"), Enumeration("6")] QualityRecordApprovalAssignment = 6,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052332, false, false, false, "9"), EnumMember, Enumeration("9")] QualityRecResolutionApproved = 9,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052200, false, false, false, "10"), EnumMember, Enumeration("10")] QualityRecResolutionRejected = 10, // 0x0000000A
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052331, false, false, false, "34"), Enumeration("34"), EnumMember] QualityRecPendingAssignment = 34, // 0x00000022
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777608, false, false, false, "40"), EnumMember, Enumeration("40")] ChangePkgApprovalAssignment = 40, // 0x00000028
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778080, false, false, false, "41"), EnumMember, Enumeration("41")] ChangePkgCollaborationAssignment = 41, // 0x00000029
    [EnumMember, Enumeration("42"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778081, false, false, false, "42")] ChangePkgCollaborationComplete = 42, // 0x0000002A
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778618, false, false, false, "43"), Enumeration("43"), EnumMember] ChangeMgtApprovalDelegation = 43, // 0x0000002B
    [Enumeration("44"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16778619, false, false, false, "44")] ChangeMgtCollaborationDelegation = 44, // 0x0000002C
  }
}
