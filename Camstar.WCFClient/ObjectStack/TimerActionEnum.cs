// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TimerActionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TimerActionEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778372, false, false, false, "1"), EnumMember] EndTxnNotExecute = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16778371, false, false, false, "2"), Enumeration("2")] EndTxnExecute = 2,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778751, false, false, false, "3")] EndTxnExecuteWithESig = 3,
  }
}
