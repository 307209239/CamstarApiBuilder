// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIModeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum UIModeEnum
  {
    [EnumMember, Metadata("Indicates the mode for which the UI is running.", "UIModeEnum", false, false, false, "Integer", 1052347, false, false, false, "1"), Enumeration("1")] Developer = 1,
    [EnumMember, Metadata("Indicates the mode for which the UI is running.", "UIModeEnum", false, false, false, "Integer", 1052349, false, false, false, "2"), Enumeration("2")] Tester = 2,
    [Enumeration("3"), EnumMember, Metadata("Indicates the mode for which the UI is running.", "UIModeEnum", false, false, false, "Integer", 1052348, false, false, false, "3")] Published = 3,
  }
}
