// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotSampleData
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
  public class LotSampleData : ContainerSampleData
  {
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_SampleTest")]
    protected new RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_AQLLevel")]
    protected new NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_InspectionLevel")]
    protected new NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_SamplingPlanDetail")]
    protected SubentityRef _SamplingPlanDetail;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_SamplesFailed")]
    protected Primitive<int> _SamplesFailed;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_InspectAllContQty")]
    protected new Primitive<bool> _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_SamplesTested")]
    protected Primitive<int> _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Rejects")]
    protected new Primitive<int> _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_TotalSamplesRequired")]
    protected new Primitive<int> _TotalSamplesRequired;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_InspectAllQtyOnFailure")]
    protected new Primitive<bool> _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_AllowedRejects")]
    protected new Primitive<int> _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_CompletedSamples")]
    protected new Primitive<int> _CompletedSamples;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is LotSampleData && object.Equals((object) this._ExportImportKey, (object) ((LotSampleData) obj)._ExportImportKey) && (object.Equals((object) this._Spec, (object) ((LotSampleData) obj)._Spec) && object.Equals((object) this._VendorItem, (object) ((LotSampleData) obj)._VendorItem)) && (object.Equals((object) this._SampleTest, (object) ((LotSampleData) obj)._SampleTest) && object.Equals((object) this._AQLLevel, (object) ((LotSampleData) obj)._AQLLevel) && (object.Equals((object) this._SamplingPlan, (object) ((LotSampleData) obj)._SamplingPlan) && object.Equals((object) this._InspectionLevel, (object) ((LotSampleData) obj)._InspectionLevel))) && (object.Equals((object) this._SamplingPlanDetail, (object) ((LotSampleData) obj)._SamplingPlanDetail) && object.Equals((object) this._SamplesFailed, (object) ((LotSampleData) obj)._SamplesFailed) && (object.Equals((object) this._InspectAllContQty, (object) ((LotSampleData) obj)._InspectAllContQty) && object.Equals((object) this._SamplesTested, (object) ((LotSampleData) obj)._SamplesTested)) && (object.Equals((object) this._Rejects, (object) ((LotSampleData) obj)._Rejects) && object.Equals((object) this._TotalSamplesRequired, (object) ((LotSampleData) obj)._TotalSamplesRequired) && (object.Equals((object) this._InspectAllQtyOnFailure, (object) ((LotSampleData) obj)._InspectAllQtyOnFailure) && object.Equals((object) this._AllowedRejects, (object) ((LotSampleData) obj)._AllowedRejects)))) && (object.Equals((object) this._CompletedSamples, (object) ((LotSampleData) obj)._CompletedSamples) && object.Equals((object) this._Resource, (object) ((LotSampleData) obj)._Resource)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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

    public new RevisionedObjectRef SampleTest
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

    public new NamedObjectRef AQLLevel
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

    public new RevisionedObjectRef SamplingPlan
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

    public new NamedObjectRef InspectionLevel
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

    public SubentityRef SamplingPlanDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (SamplingPlanDetail));
      }
    }

    public Primitive<int> SamplesFailed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesFailed), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SamplesFailed));
      }
    }

    public new Primitive<bool> InspectAllContQty
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

    public Primitive<int> SamplesTested
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesTested), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SamplesTested));
      }
    }

    public new Primitive<int> Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Rejects));
      }
    }

    public new Primitive<int> TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public new Primitive<bool> InspectAllQtyOnFailure
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

    public new Primitive<int> AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public new Primitive<int> CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompletedSamples));
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
