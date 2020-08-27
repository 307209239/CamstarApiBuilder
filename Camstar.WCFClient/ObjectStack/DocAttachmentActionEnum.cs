// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentActionEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DocAttachmentActionEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051127, false, false, false, "0"), Enumeration("0"), EnumMember] Download,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051128, false, false, false, "1"), EnumMember, Enumeration("1")] Upload,
    [EnumMember, Metadata("Generic Integer", "", false, false, false, "Integer", 1050902, false, false, false, "2"), Enumeration("2")] Delete,
    [EnumMember, Enumeration("3"), Metadata("Generic Integer", "", false, false, false, "Integer", 1050901, false, false, false, "3")] Update,
  }
}
