// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectActionsEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ProcessObjectActionsEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052070, false, false, false, "1"), EnumMember, Enumeration("1")] View = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052071, false, false, false, "2")] Edit = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052165, false, false, false, "4"), Enumeration("4")] Designate = 4,
    [Enumeration("8"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052166, false, false, false, "8")] Route = 8,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052167, false, false, false, "16"), EnumMember, Enumeration("16")] Reassign = 16, // 0x00000010
    [EnumMember, Enumeration("32"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051842, false, false, false, "32")] Complete = 32, // 0x00000020
    [Enumeration("64"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050430, false, false, false, "64"), EnumMember] Open = 64, // 0x00000040
    [Enumeration("128"), Metadata("Generic Integer", "", false, false, false, "Integer", 1051041, false, false, false, "128"), EnumMember] Void = 128, // 0x00000080
    [EnumMember, Enumeration("256"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052168, false, false, false, "256")] Modify = 256, // 0x00000100
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052169, false, false, false, "512"), EnumMember, Enumeration("512")] EndCollaboration = 512, // 0x00000200
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052078, false, false, false, "1024"), EnumMember, Enumeration("1024")] CancelApproval = 1024, // 0x00000400
    [Enumeration("2048"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052170, false, false, false, "2048")] Reprocess = 2048, // 0x00000800
    [EnumMember, Metadata("View = 1\r\nEdit = 2\r\nDesignate = 4\r\nRoute = 8\r\nReassign = 16\r\nComplete = 32\r\nOpen = 64\r\nVoid = 128\r\nModify = 256\r\nEndCollaboration = 512\r\nCancelApproval = 1024\r\nReprocess = 2048\r\nEditFlag_AssigneeReadOnly = 33554432\r\nEditFlag_AllReadOnly = 67108864\r\nEditFlag_OnHold = 134217728", "ProcessObjectActionsEnum", false, false, false, "Integer", 1052265, false, false, false, "4096"), Enumeration("4096")] Approve = 4096, // 0x00001000
    [Enumeration("33554432"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052171, false, false, false, "33554432"), EnumMember] EditFlag_AssigneeReadOnly = 33554432, // 0x02000000
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052172, false, false, false, "67108864"), EnumMember, Enumeration("67108864")] EditFlag_AllReadOnly = 67108864, // 0x04000000
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052173, false, false, false, "134217728"), Enumeration("134217728")] EditFlag_OnHold = 134217728, // 0x08000000
  }
}
