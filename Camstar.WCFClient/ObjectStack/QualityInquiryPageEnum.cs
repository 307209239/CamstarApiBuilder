// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityInquiryPageEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum QualityInquiryPageEnum
  {
    [Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052283, false, false, false, "1"), EnumMember] BasicSearch = 1,
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1052284, false, false, false, "2"), Enumeration("2")] ManageMyRecords = 2,
    [Enumeration("3"), Metadata("Generic Integer", "", false, false, true, "Integer", 1052285, false, false, false, "3"), EnumMember] CrossRefSearch = 3,
  }
}
