// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ConciergePageMappingEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ConciergePageMappingEnum
  {
    [Enumeration("ActivityInvestExecution"), EnumMember, Metadata("Generic String", "", false, false, false, "String", 1052365, false, false, false, "ActivityInvestExecution")] ActivityInvestExecution = -2060122900, // 0x853504EC
    [EnumMember, Metadata("Generic String", "", false, false, false, "String", 1052364, false, false, false, "ActivityDispExecution"), Enumeration("ActivityDispExecution")] ActivityDispExecution = -1718854763, // 0x998C5B95
    [EnumMember, Metadata("Generic String", "", false, false, false, "String", 1051769, false, false, false, "EventCreatePageflow"), Enumeration("EventCreatePageflow")] EventCreatePageflow = -1676469971, // 0x9C13192D
    [Enumeration("ApprovalPlanEntry"), EnumMember, Metadata("Generic String", "", false, false, false, "String", 1051775, false, false, false, "ApprovalPlanEntry")] ApprovalPlanEntry = -1568069166, // 0xA28929D2
    [Enumeration("CAPACreatePageflow"), Metadata("Generic String", "", false, false, false, "String", 1051770, false, false, false, "CAPACreatePageflow"), EnumMember] CAPACreatePageflow = -993212906, // 0xC4CCC616
    [Metadata("Generic String", "", false, false, false, "String", 1051778, false, false, false, "ApprovalQualityObjectComplete"), EnumMember, Enumeration("ApprovalQualityObjectComplete")] ApprovalQualityObjectComplete = -898415530, // 0xCA734456
    [EnumMember, Enumeration("PlanOwnership"), Metadata("Generic String", "", false, false, false, "String", 1051774, false, false, false, "PlanOwnership")] PlanOwnership = -230710742, // 0xF23FA22A
    [EnumMember, Enumeration("ApprovalQualityObjectEntry"), Metadata("Generic String", "", false, false, false, "String", 1051777, false, false, false, "ApprovalQualityObjectEntry")] ApprovalQualityObjectEntry = -70110997, // 0xFBD230EB
    [Metadata("Generic String", "", false, false, false, "String", 1051771, false, false, false, "ActivityExecution"), EnumMember, Enumeration("ActivityExecution")] ActivityExecution = 315893307, // 0x12D4263B
    [Metadata("Generic String", "", false, false, false, "String", 1051768, false, false, false, "CAPARecordView"), EnumMember, Enumeration("CAPARecordView")] CAPARecordView = 513332047, // 0x1E98D34F
    [EnumMember, Enumeration("ApprovalPhaseEntry"), Metadata("Generic String", "", false, false, false, "String", 1051776, false, false, false, "ApprovalPhaseEntry")] ApprovalPhaseEntry = 594100376, // 0x23694098
    [Metadata("Generic String", "", false, false, false, "String", 1051767, false, false, false, "EventRecordView"), EnumMember, Enumeration("EventRecordView")] EventRecordView = 667287746, // 0x27C600C2
    [EnumMember, Enumeration("PhaseOwnership"), Metadata("Generic String", "", false, false, false, "String", 1051773, false, false, false, "PhaseOwnership")] PhaseOwnership = 1100873186, // 0x419DFDE2
    [Enumeration("ProcessModelOwnership"), Metadata("Generic String", "", false, false, false, "String", 1051772, false, false, false, "ProcessModelOwnership"), EnumMember] ProcessModelOwnership = 1647429279, // 0x6231C69F
  }
}
