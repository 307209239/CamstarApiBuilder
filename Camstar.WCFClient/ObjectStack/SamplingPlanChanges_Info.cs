// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanChanges_Info
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
  public class SamplingPlanChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SamplingPlanDetails")]
    protected SamplingPlanDetailsChanges_Info _SamplingPlanDetails;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SwitchingRule")]
    protected Info _SwitchingRule;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_AQLLevel")]
    protected Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_InspectionLevel")]
    protected Info _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SampleRateMaxDuration")]
    protected Info _SampleRateMaxDuration;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SampleRate")]
    protected Info _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SwitchingRuleMaxDuration")]
    protected Info _SwitchingRuleMaxDuration;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_SampleSizeBasedOnStartQty")]
    protected Info _SampleSizeBasedOnStartQty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Info_Name")]
    protected new Info _Name;

    public Info Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Vendor));
      }
    }

    public Info VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItem));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public SamplingPlanDetailsChanges_Info SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (SamplingPlanDetailsChanges_Info) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public Info SwitchingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SwitchingRule));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public Info InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info SampleRateMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateMaxDuration), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRateMaxDuration));
      }
    }

    public Info SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Info SwitchingRuleMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleMaxDuration), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SwitchingRuleMaxDuration));
      }
    }

    public Info SampleSizeBasedOnStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeBasedOnStartQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleSizeBasedOnStartQty));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
