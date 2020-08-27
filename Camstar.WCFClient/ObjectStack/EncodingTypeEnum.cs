// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EncodingTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum EncodingTypeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777651, false, false, false, "1"), EnumMember, Enumeration("1")] UTF16LE = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777652, false, false, false, "2"), Enumeration("2"), EnumMember] UTF16BE = 2,
    [Enumeration("3"), EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 16777653, false, false, false, "3")] UTF8 = 3,
    [Enumeration("4"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050006, false, false, false, "4"), EnumMember] ASCII = 4,
  }
}
