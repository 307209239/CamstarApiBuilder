// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ConciergeTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ConciergeTypeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051750, false, false, false, "1"), Enumeration("1"), EnumMember] QualityRecOwnershipAssignment = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051755, false, false, false, "6"), Enumeration("6"), EnumMember] QualityRecordApprovalAssignment = 6,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052332, false, false, false, "9"), EnumMember, Enumeration("9")] QualityRecResolutionApproved = 9,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052200, false, false, false, "10"), EnumMember, Enumeration("10")] QualityRecResolutionRejected = 10, // 0x0000000A
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052331, false, false, false, "34"), Enumeration("34"), EnumMember] QualityRecPendingAssignment = 34, // 0x00000022
  }
}
