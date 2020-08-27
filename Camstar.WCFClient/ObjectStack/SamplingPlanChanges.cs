// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanChanges
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
  public class SamplingPlanChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SamplingPlanDetails")]
    protected SamplingPlanDetailsChanges[] _SamplingPlanDetails;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SwitchingRule")]
    protected RevisionedObjectRef _SwitchingRule;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_InspectionLevel")]
    protected NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SampleRateMaxDuration")]
    protected Primitive<int> _SampleRateMaxDuration;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SampleRate")]
    protected Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SwitchingRuleMaxDuration")]
    protected Primitive<int> _SwitchingRuleMaxDuration;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_SampleSizeBasedOnStartQty")]
    protected Primitive<bool> _SampleSizeBasedOnStartQty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SamplingPlanChanges && object.Equals((object) this._Vendor, (object) ((SamplingPlanChanges) obj)._Vendor) && (object.Equals((object) this._VendorItem, (object) ((SamplingPlanChanges) obj)._VendorItem) && object.Equals((object) this._Spec, (object) ((SamplingPlanChanges) obj)._Spec)) && (this.CompareArrays((Array) this._SamplingPlanDetails, (Array) ((SamplingPlanChanges) obj)._SamplingPlanDetails) && object.Equals((object) this._SwitchingRule, (object) ((SamplingPlanChanges) obj)._SwitchingRule) && (object.Equals((object) this._ObjectToChange, (object) ((SamplingPlanChanges) obj)._ObjectToChange) && object.Equals((object) this._AQLLevel, (object) ((SamplingPlanChanges) obj)._AQLLevel))) && (object.Equals((object) this._InspectionLevel, (object) ((SamplingPlanChanges) obj)._InspectionLevel) && object.Equals((object) this._Base, (object) ((SamplingPlanChanges) obj)._Base) && (object.Equals((object) this._SampleRateMaxDuration, (object) ((SamplingPlanChanges) obj)._SampleRateMaxDuration) && object.Equals((object) this._SampleRate, (object) ((SamplingPlanChanges) obj)._SampleRate)) && (object.Equals((object) this._SwitchingRuleMaxDuration, (object) ((SamplingPlanChanges) obj)._SwitchingRuleMaxDuration) && object.Equals((object) this._SampleSizeBasedOnStartQty, (object) ((SamplingPlanChanges) obj)._SampleSizeBasedOnStartQty) && (object.Equals((object) this._Resource, (object) ((SamplingPlanChanges) obj)._Resource) && object.Equals((object) this._Name, (object) ((SamplingPlanChanges) obj)._Name)))) && base.Equals(obj);
    }

    public NamedObjectRef Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Vendor));
      }
    }

    public NamedSubentityRef VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (VendorItem));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public SamplingPlanDetailsChanges[] SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (SamplingPlanDetailsChanges[]) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public RevisionedObjectRef SwitchingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRule), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SwitchingRule));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public NamedObjectRef InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Primitive<int> SampleRateMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateMaxDuration), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SampleRateMaxDuration));
      }
    }

    public Primitive<int> SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Primitive<int> SwitchingRuleMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleMaxDuration), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SwitchingRuleMaxDuration));
      }
    }

    public Primitive<bool> SampleSizeBasedOnStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeBasedOnStartQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SampleSizeBasedOnStartQty));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
