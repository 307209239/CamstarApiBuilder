// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageImportStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ChangePackageImportStatusEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 16777366, false, false, false, "1"), EnumMember] PendingActivation = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16777367, false, false, false, "2"), Enumeration("2")] ActivationIncomplete = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1052728, false, false, false, "3")] Activated = 3,
  }
}
