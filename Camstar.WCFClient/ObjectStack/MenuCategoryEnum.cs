// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuCategoryEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum MenuCategoryEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1049958, false, false, false, "1"), EnumMember] ContainerTransactions = 1,
    [Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1049959, false, false, false, "2"), EnumMember] ResourceTransactions = 2,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049960, false, false, false, "3"), EnumMember, Enumeration("3")] InquiryTransactions = 3,
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049961, false, false, false, "4"), EnumMember, Enumeration("4")] QueryTransactions = 4,
  }
}
