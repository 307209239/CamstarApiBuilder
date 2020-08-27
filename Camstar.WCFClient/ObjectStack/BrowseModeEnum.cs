// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BrowseModeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum BrowseModeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779310, false, false, false, "1"), EnumMember, Enumeration("1")] HTTPFile = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 16779311, false, false, false, "2")] LocalFile = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1049620, false, false, false, "3")] Url = 3,
  }
}
