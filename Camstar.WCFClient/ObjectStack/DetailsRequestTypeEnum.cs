// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetailsRequestTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DetailsRequestTypeEnum
  {
    [Enumeration("0"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052878, false, false, false, "0"), EnumMember] HistoryMainlines,
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052880, false, false, false, "1"), EnumMember] SummaryDetails,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052879, false, false, false, "2")] NextLevelDetails,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052874, false, false, false, "3"), Enumeration("3")] ESignatures,
    [Enumeration("4"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050562, false, false, false, "4")] DataCollection,
    [EnumMember, Enumeration("5"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051017, false, false, false, "5")] Computation,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052875, false, false, false, "6"), EnumMember, Enumeration("6")] LabelPrinting,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052876, false, false, false, "7"), Enumeration("7")] StartAttributes,
    [Enumeration("8"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052207, false, false, false, "8"), EnumMember] DocAttachments,
    [Enumeration("9"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1051787, false, false, false, "9")] WIPMsgs,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052956, false, false, false, "10"), Enumeration("10")] EventLog,
    [Enumeration("11"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051083, false, false, false, "11"), EnumMember] EventLot,
  }
}
