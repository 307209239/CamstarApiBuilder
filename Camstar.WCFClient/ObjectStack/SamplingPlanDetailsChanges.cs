// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanDetailsChanges
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
  public class SamplingPlanDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_InspectionLevel")]
    protected NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_SwitchingRule")]
    protected RevisionedObjectRef _SwitchingRule;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_SampleRate")]
    protected Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_InspectAll")]
    protected Primitive<bool> _InspectAll;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_InspectAllContQty")]
    protected Primitive<bool> _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_InspectAllQtyOnFailure")]
    protected Primitive<bool> _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is SamplingPlanDetailsChanges && object.Equals((object) this._Vendor, (object) ((SamplingPlanDetailsChanges) obj)._Vendor) && (object.Equals((object) this._Sequence, (object) ((SamplingPlanDetailsChanges) obj)._Sequence) && object.Equals((object) this._Spec, (object) ((SamplingPlanDetailsChanges) obj)._Spec)) && (object.Equals((object) this._VendorItem, (object) ((SamplingPlanDetailsChanges) obj)._VendorItem) && object.Equals((object) this._InspectionLevel, (object) ((SamplingPlanDetailsChanges) obj)._InspectionLevel) && (object.Equals((object) this._AQLLevel, (object) ((SamplingPlanDetailsChanges) obj)._AQLLevel) && object.Equals((object) this._SampleTest, (object) ((SamplingPlanDetailsChanges) obj)._SampleTest))) && (object.Equals((object) this._SwitchingRule, (object) ((SamplingPlanDetailsChanges) obj)._SwitchingRule) && object.Equals((object) this._ListItemToChange, (object) ((SamplingPlanDetailsChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((SamplingPlanDetailsChanges) obj)._ObjectToChange) && object.Equals((object) this._SampleRate, (object) ((SamplingPlanDetailsChanges) obj)._SampleRate)) && (object.Equals((object) this._InspectAll, (object) ((SamplingPlanDetailsChanges) obj)._InspectAll) && object.Equals((object) this._InspectAllContQty, (object) ((SamplingPlanDetailsChanges) obj)._InspectAllContQty) && (object.Equals((object) this._InspectAllQtyOnFailure, (object) ((SamplingPlanDetailsChanges) obj)._InspectAllQtyOnFailure) && object.Equals((object) this._IsFrozen, (object) ((SamplingPlanDetailsChanges) obj)._IsFrozen)))) && object.Equals((object) this._Resource, (object) ((SamplingPlanDetailsChanges) obj)._Resource) && base.Equals(obj);
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

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
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

    public RevisionedObjectRef SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleTest));
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

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
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

    public Primitive<bool> InspectAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAll), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAll));
      }
    }

    public Primitive<bool> InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAllContQty));
      }
    }

    public Primitive<bool> InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
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
  }
}
