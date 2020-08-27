// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanDataHistoryDetails
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
  public class FailurePlanDataHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDataHistoryDetails_Plan")]
    protected NamedSubentityRef _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDataHistoryDetails_PlanType")]
    protected Enumeration<FailurePlanTypeEnum, int> _PlanType;

    public override bool Equals(object obj)
    {
      return obj is FailurePlanDataHistoryDetails && object.Equals((object) this._Plan, (object) ((FailurePlanDataHistoryDetails) obj)._Plan) && object.Equals((object) this._PlanType, (object) ((FailurePlanDataHistoryDetails) obj)._PlanType) && base.Equals(obj);
    }

    public NamedSubentityRef Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Plan));
      }
    }

    public Enumeration<FailurePlanTypeEnum, int> PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Enumeration<FailurePlanTypeEnum, int>) this.PropertyGet(nameof (PlanType));
      }
    }
  }
}
