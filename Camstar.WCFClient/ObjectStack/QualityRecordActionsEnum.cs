// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityRecordActionsEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum QualityRecordActionsEnum
  {
    [EnumMember, Enumeration("0"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050506, false, false, false, "0")] None = 0,
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052070, false, false, false, "1")] View = 1,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052071, false, false, false, "2"), EnumMember, Enumeration("2")] Edit = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052072, false, false, false, "4"), Enumeration("4")] ChangeOwner = 4,
    [Enumeration("8"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052073, false, false, false, "8")] ChangeCategory = 8,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052074, false, false, false, "16"), EnumMember, Enumeration("16")] Triage = 16, // 0x00000010
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052075, false, false, false, "32"), Enumeration("32")] InitiateCAR = 32, // 0x00000020
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052076, false, false, false, "64"), Enumeration("64")] Resolve = 64, // 0x00000040
    [EnumMember, Enumeration("128"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052077, false, false, false, "128")] AssignProcessModel = 128, // 0x00000080
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052078, false, false, false, "256"), EnumMember, Enumeration("256")] CancelApproval = 256, // 0x00000100
    [EnumMember, Metadata("Enumeration for the Quality Record Actions:\r\n0 = None\r\n1 = View\r\n2 = Edit\r\n4 = ChangeOwner\r\n8 = ChangeCategory\r\n16 = Triage\r\n32 = InitiateCAR\r\n64 = Resolve\r\n128 = AssignProcessModel\r\n256 = CancelApproval\r\n", "QualityRecordActionsEnum", false, false, false, "Integer", 1052265, false, false, false, "512"), Enumeration("512")] Approve = 512, // 0x00000200
  }
}
