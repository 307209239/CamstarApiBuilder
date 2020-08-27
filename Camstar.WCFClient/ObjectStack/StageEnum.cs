// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StageEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum StageEnum
  {
    [Enumeration("5"), EnumMember, Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051369, false, false, false, "5")] Voided = 5,
    [EnumMember, Enumeration("20"), Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1050762, false, false, false, "20")] Pending = 20, // 0x00000014
    [Enumeration("25"), EnumMember, Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1052055, false, false, false, "25")] InCollaboration = 25, // 0x00000019
    [Enumeration("30"), EnumMember, Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051367, false, false, false, "30")] InReview = 30, // 0x0000001E
    [Enumeration("45"), EnumMember, Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1048801, false, false, false, "45")] InProcess = 45, // 0x0000002D
    [EnumMember, Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1050814, false, false, false, "50"), Enumeration("50")] Completed = 50, // 0x00000032
  }
}
