// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PkgApprovalEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PkgApprovalEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048824, false, false, false, "1"), Enumeration("1"), EnumMember] Owner = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1051691, false, false, false, "2"), Enumeration("2")] Approvers = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16778432, false, false, false, "3"), Enumeration("3")] ApproverEscalationRecipients = 3,
  }
}
