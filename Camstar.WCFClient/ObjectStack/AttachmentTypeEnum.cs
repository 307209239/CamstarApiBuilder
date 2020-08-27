// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachmentTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum AttachmentTypeEnum
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777535, false, false, false, "1"), EnumMember, Enumeration("1")] NewDocumentNOReuse = 1,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777536, false, false, false, "2"), EnumMember, Enumeration("2")] NewDocumentReuse = 2,
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777534, false, false, false, "3"), Enumeration("3"), EnumMember] ExistingDocument = 3,
  }
}
