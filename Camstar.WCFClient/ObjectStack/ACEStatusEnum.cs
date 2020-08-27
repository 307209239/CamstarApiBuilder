// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ACEStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ACEStatusEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050634, false, false, false, "1")] ACESuccess = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1050635, false, false, false, "2")] ACEFSuccess = 2,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050636, false, false, false, "3"), Enumeration("3")] ACEFFail = 3,
  }
}
