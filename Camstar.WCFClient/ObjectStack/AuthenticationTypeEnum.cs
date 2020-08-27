// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuthenticationTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum AuthenticationTypeEnum
  {
    [EnumMember, Enumeration("10"), Metadata("Generic Integer", "", false, false, false, "Integer", 16779000, false, false, false, "10")] Basic = 10, // 0x0000000A
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050506, false, false, false, "20"), EnumMember, Enumeration("20")] None = 20, // 0x00000014
  }
}
