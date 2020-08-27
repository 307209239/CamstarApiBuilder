// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanDetails_Info
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
  public class FailurePlanDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Info_PlanType")]
    protected Info _PlanType;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Info_Plan")]
    protected Info _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanDetails_Info_FailurePlanData")]
    protected Info _FailurePlanData;

    public Info PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlanType));
      }
    }

    public Info Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Plan));
      }
    }

    public Info FailurePlanData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailurePlanData));
      }
    }
  }
}
