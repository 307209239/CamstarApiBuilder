// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanDataHistoryDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class FailurePlanDataHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, true, "NamedSubentityRef", 1051188, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDataHistoryDetails_Environment_Plan")]
    protected Environment _Plan;
    [Metadata("The usage of the plan for the cause of the failure.", "FailurePlanTypeEnum", false, false, true, "Integer", 1052092, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDataHistoryDetails_Environment_PlanType")]
    protected Environment _PlanType;

    public Environment Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Plan));
      }
    }

    public Environment PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlanType));
      }
    }
  }
}
