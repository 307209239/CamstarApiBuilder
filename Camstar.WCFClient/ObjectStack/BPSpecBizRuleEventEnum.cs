// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSpecBizRuleEventEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum BPSpecBizRuleEventEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779360, false, false, false, "1"), EnumMember, Enumeration("1")] PreValidateUser = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779356, false, false, false, "2"), Enumeration("2"), EnumMember] ValidateUser = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779355, false, false, false, "3"), Enumeration("3"), EnumMember] PreExecuteUser = 3,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779354, false, false, false, "4"), Enumeration("4"), EnumMember] ExecuteUser = 4,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779353, false, false, false, "5"), EnumMember, Enumeration("5")] ProcessAfterCommitUser = 5,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16779359, false, false, false, "6"), Enumeration("6")] ExportInfoInitializeUser = 6,
  }
}
