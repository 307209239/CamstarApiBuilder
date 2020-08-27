// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ButtonPositionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum ButtonPositionTypeEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052833, false, false, false, "1"), EnumMember] RightPane = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052834, false, false, false, "2"), EnumMember, Enumeration("2")] LeftPane = 2,
  }
}
