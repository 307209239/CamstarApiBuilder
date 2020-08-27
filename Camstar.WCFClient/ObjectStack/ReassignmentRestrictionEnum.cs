// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReassignmentRestrictionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ReassignmentRestrictionEnum
  {
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, false, "Integer", 1051364, false, false, false, "1"), EnumMember, Enumeration("1")] WithinRole = 1,
    [EnumMember, Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, false, "Integer", 1051362, false, false, false, "2"), Enumeration("2")] AnyUser = 2,
    [EnumMember, Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, false, "Integer", 1051363, false, false, false, "3"), Enumeration("3")] NotAllowed = 3,
  }
}
