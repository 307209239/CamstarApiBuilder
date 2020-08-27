// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CARResolutionActionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum CARResolutionActionEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1051478, false, false, false, "1"), Enumeration("1")] Close = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051474, false, false, false, "2")] AttachToCAPA = 2,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, true, "Integer", 1051475, false, false, false, "3")] CreateCAPA = 3,
  }
}
