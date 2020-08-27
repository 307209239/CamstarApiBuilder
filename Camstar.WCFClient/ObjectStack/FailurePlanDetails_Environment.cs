// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanDetails_Environment
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
  public class FailurePlanDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("The usage of the plan for the cause of the failure.", "FailurePlanTypeEnum", false, false, false, "Integer", 1051706, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Environment_PlanType")]
    protected Environment _PlanType;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Environment_Plan")]
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, false, "NamedSubentityRef", 1051188, false, false, true, null)]
    protected Environment _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Environment_FailurePlanData")]
    [Metadata("Specifies the plan that will be executed to correct the failure or prevent it in the future.", "FailurePlanData", false, false, false, "SubentityRef", 1052093, false, false, false, null)]
    protected Environment _FailurePlanData;

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

    public Environment FailurePlanData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailurePlanData));
      }
    }
  }
}
