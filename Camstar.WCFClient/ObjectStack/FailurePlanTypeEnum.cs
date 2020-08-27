// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum FailurePlanTypeEnum
  {
    [Metadata("The usage of the plan for the cause of the failure.", "FailurePlanTypeEnum", false, false, false, "Integer", 1051700, false, false, false, "1"), Enumeration("1"), EnumMember] Corrective = 1,
    [Enumeration("2"), Metadata("The usage of the plan for the cause of the failure.", "FailurePlanTypeEnum", false, false, false, "Integer", 1051701, false, false, false, "2"), EnumMember] Preventive = 2,
  }
}
