// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChildProcessingEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ChildProcessingEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050282, false, false, false, "0"), Enumeration("0")] NoDescendants,
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050283, false, false, false, "1")] ImmediateDescendants,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050284, false, false, false, "2"), Enumeration("2")] AllDescendants,
  }
}
