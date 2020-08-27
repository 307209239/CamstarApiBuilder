// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleStatusEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum SampleStatusEnum
  {
    [Enumeration("Pass"), EnumMember, Metadata("Generic String", "", false, false, false, "String", 1050546, false, false, false, "Pass")] Pass = -1872638567, // 0x9061CD99
    [EnumMember, Metadata("Generic String", "", false, false, false, "String", 1052696, false, false, false, "Fail"), Enumeration("Fail")] Fail = 405905394, // 0x18319FF2
    [Metadata("Generic String", "", false, false, false, "String", 1048801, false, false, false, "In Process"), EnumMember, Enumeration("In Process")] InProcess = 1284449426, // 0x4C8F2492
  }
}
