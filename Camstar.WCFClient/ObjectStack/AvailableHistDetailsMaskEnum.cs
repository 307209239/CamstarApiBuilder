// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AvailableHistDetailsMaskEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum AvailableHistDetailsMaskEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052877, false, false, false, "1")] SummaryDetails = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052874, false, false, false, "2"), EnumMember] ESignatures = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050562, false, false, false, "4"), Enumeration("4")] DataCollection = 4,
    [Enumeration("8"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1051017, false, false, false, "8")] Computation = 8,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052875, false, false, false, "16"), EnumMember, Enumeration("16")] LabelPrinting = 16, // 0x00000010
    [EnumMember, Enumeration("32"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052876, false, false, false, "32")] StartAttributes = 32, // 0x00000020
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051787, false, false, false, "64"), Enumeration("64"), EnumMember] WIPMsgs = 64, // 0x00000040
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051144, false, false, false, "128"), EnumMember, Enumeration("128")] DocAttachment = 128, // 0x00000080
    [EnumMember, Enumeration("256"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052956, false, false, false, "256")] EventLog = 256, // 0x00000100
    [EnumMember, Enumeration("512"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051083, false, false, false, "512")] EventLot = 512, // 0x00000200
  }
}
