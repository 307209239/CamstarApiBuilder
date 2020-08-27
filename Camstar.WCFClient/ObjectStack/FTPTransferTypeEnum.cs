// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FTPTransferTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum FTPTransferTypeEnum
  {
    [EnumMember, Enumeration("Binary"), Metadata("Generic String", "", false, false, true, "String", 1050005, false, false, false, "Binary")] Binary = -1798705473, // 0x94C9EEBF
    [Enumeration("ASCII"), Metadata("Generic String", "", false, false, true, "String", 1050006, false, false, false, "ASCII"), EnumMember] ASCII = -1677634327, // 0x9C0154E9
  }
}
