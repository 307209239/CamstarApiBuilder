// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanDetails
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
  public class FailurePlanDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_PlanType")]
    protected Enumeration<FailurePlanTypeEnum, int> _PlanType;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Plan")]
    protected NamedSubentityRef _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_FailurePlanData")]
    protected SubentityRef _FailurePlanData;

    public override bool Equals(object obj)
    {
      return obj is FailurePlanDetails && object.Equals((object) this._PlanType, (object) ((FailurePlanDetails) obj)._PlanType) && (object.Equals((object) this._Plan, (object) ((FailurePlanDetails) obj)._Plan) && object.Equals((object) this._FailurePlanData, (object) ((FailurePlanDetails) obj)._FailurePlanData)) && base.Equals(obj);
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

    public SubentityRef FailurePlanData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (FailurePlanData));
      }
    }
  }
}
