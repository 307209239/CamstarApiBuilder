// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TaskTypeEnum
  {
    [Enumeration("1"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050509, false, false, false, "1")] StartProcessTask = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050510, false, false, false, "2")] EndProcessTask = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050511, false, false, false, "3"), EnumMember] RegularTask = 3,
  }
}
