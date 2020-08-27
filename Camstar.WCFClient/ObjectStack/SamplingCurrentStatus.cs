// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingCurrentStatus
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
  public class SamplingCurrentStatus : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_SamplePlanInspectionLevel")]
    protected NamedObjectRef _SamplePlanInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_CurrentInspectionLevel")]
    protected NamedObjectRef _CurrentInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_LastUpdateDate")]
    protected Primitive<DateTime> _LastUpdateDate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_SampleRateCounter")]
    protected Primitive<int> _SampleRateCounter;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_CurrentSampleRate")]
    protected Primitive<int> _CurrentSampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is SamplingCurrentStatus && object.Equals((object) this._VendorItem, (object) ((SamplingCurrentStatus) obj)._VendorItem) && (object.Equals((object) this._Vendor, (object) ((SamplingCurrentStatus) obj)._Vendor) && object.Equals((object) this._Spec, (object) ((SamplingCurrentStatus) obj)._Spec)) && (object.Equals((object) this._SampleTest, (object) ((SamplingCurrentStatus) obj)._SampleTest) && object.Equals((object) this._AQLLevel, (object) ((SamplingCurrentStatus) obj)._AQLLevel) && (object.Equals((object) this._SamplingLot, (object) ((SamplingCurrentStatus) obj)._SamplingLot) && object.Equals((object) this._SamplePlanInspectionLevel, (object) ((SamplingCurrentStatus) obj)._SamplePlanInspectionLevel))) && (object.Equals((object) this._SamplingPlan, (object) ((SamplingCurrentStatus) obj)._SamplingPlan) && object.Equals((object) this._CurrentInspectionLevel, (object) ((SamplingCurrentStatus) obj)._CurrentInspectionLevel) && (object.Equals((object) this._LastUpdateDate, (object) ((SamplingCurrentStatus) obj)._LastUpdateDate) && object.Equals((object) this._SampleRateCounter, (object) ((SamplingCurrentStatus) obj)._SampleRateCounter)) && (object.Equals((object) this._CurrentSampleRate, (object) ((SamplingCurrentStatus) obj)._CurrentSampleRate) && object.Equals((object) this._Product, (object) ((SamplingCurrentStatus) obj)._Product) && object.Equals((object) this._Resource, (object) ((SamplingCurrentStatus) obj)._Resource))) && base.Equals(obj);
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

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public NamedObjectRef SamplePlanInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplePlanInspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplePlanInspectionLevel));
      }
    }

    public RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public NamedObjectRef CurrentInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentInspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CurrentInspectionLevel));
      }
    }

    public Primitive<DateTime> LastUpdateDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdateDate));
      }
    }

    public Primitive<int> SampleRateCounter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateCounter), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SampleRateCounter));
      }
    }

    public Primitive<int> CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentSampleRate));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
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
