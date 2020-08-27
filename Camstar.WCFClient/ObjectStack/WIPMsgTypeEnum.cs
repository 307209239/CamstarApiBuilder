// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum WIPMsgTypeEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1049498, false, false, false, "1")] AllKeys = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1048887, false, false, false, "2")] LabelKeys = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1048889, false, false, false, "3"), Enumeration("3")] OperationKeys = 3,
  }
}
