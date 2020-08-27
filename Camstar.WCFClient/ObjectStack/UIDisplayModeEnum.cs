// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIDisplayModeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum UIDisplayModeEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052835, false, false, false, "1")] Disable = 1,
    [EnumMember, Enumeration("2"), Metadata("Generic Integer", "", false, false, false, "Integer", 1052836, false, false, false, "2")] Hide = 2,
  }
}
