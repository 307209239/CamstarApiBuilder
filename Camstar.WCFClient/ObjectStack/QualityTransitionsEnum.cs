// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityTransitionsEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum QualityTransitionsEnum
  {
    [Enumeration("FromCompleted"), Metadata("This is the list of transitions to which an approval sheet can be assigned.  The default values will be used as the Name of the ApprovalSheet in the list of sheets", "QualityTransitionsEnum", false, false, false, "String", 1051608, false, false, false, "FromCompleted"), EnumMember] FromCompleted = 375922455, // 0x16681F17
  }
}
