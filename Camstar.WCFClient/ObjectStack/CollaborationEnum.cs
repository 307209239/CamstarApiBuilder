// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaborationEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum CollaborationEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048824, false, false, false, "1"), EnumMember, Enumeration("1")] Owner = 1,
    [Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 16778078, false, false, false, "4"), EnumMember] Collaborators = 4,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 16778433, false, false, false, "5"), Enumeration("5")] CollaboratorEscalationRecipient = 5,
  }
}
