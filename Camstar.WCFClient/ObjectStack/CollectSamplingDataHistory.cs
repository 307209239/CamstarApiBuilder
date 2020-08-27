// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CollectLotSamplingDataHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class CollectSamplingDataHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_HistoryDetails")]
    protected CollectSamplingHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_InspectionLevel")]
    protected NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_AllowedRejects")]
    protected Primitive<int> _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_TotalPassedSamples")]
    protected Primitive<int> _TotalPassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_SamplesTested")]
    protected Primitive<int> _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_RequiredSamples")]
    protected Primitive<int> _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_TxnDateGMT")]
    protected Primitive<DateTime> _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_TotalSamplesCompleted")]
    protected Primitive<int> _TotalSamplesCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_SamplingStatus")]
    protected Primitive<string> _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_TotalRejects")]
    protected Primitive<int> _TotalRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingDataHistory && object.Equals((object) this._VendorItem, (object) ((CollectSamplingDataHistory) obj)._VendorItem) && (object.Equals((object) this._Vendor, (object) ((CollectSamplingDataHistory) obj)._Vendor) && object.Equals((object) this._Spec, (object) ((CollectSamplingDataHistory) obj)._Spec)) && (object.Equals((object) this._ExportImportKey, (object) ((CollectSamplingDataHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CollectSamplingDataHistory) obj)._HistoryDetails) && (object.Equals((object) this._SampleTest, (object) ((CollectSamplingDataHistory) obj)._SampleTest) && object.Equals((object) this._InspectionLevel, (object) ((CollectSamplingDataHistory) obj)._InspectionLevel))) && (object.Equals((object) this._SamplingPlan, (object) ((CollectSamplingDataHistory) obj)._SamplingPlan) && object.Equals((object) this._AQLLevel, (object) ((CollectSamplingDataHistory) obj)._AQLLevel) && (object.Equals((object) this._AllowedRejects, (object) ((CollectSamplingDataHistory) obj)._AllowedRejects) && object.Equals((object) this._HistoryId, (object) ((CollectSamplingDataHistory) obj)._HistoryId)) && (object.Equals((object) this._TotalPassedSamples, (object) ((CollectSamplingDataHistory) obj)._TotalPassedSamples) && object.Equals((object) this._SamplesTested, (object) ((CollectSamplingDataHistory) obj)._SamplesTested) && (object.Equals((object) this._RequiredSamples, (object) ((CollectSamplingDataHistory) obj)._RequiredSamples) && object.Equals((object) this._TxnDateGMT, (object) ((CollectSamplingDataHistory) obj)._TxnDateGMT)))) && (object.Equals((object) this._TotalSamplesCompleted, (object) ((CollectSamplingDataHistory) obj)._TotalSamplesCompleted) && object.Equals((object) this._SamplingStatus, (object) ((CollectSamplingDataHistory) obj)._SamplingStatus) && (object.Equals((object) this._TotalRejects, (object) ((CollectSamplingDataHistory) obj)._TotalRejects) && object.Equals((object) this._Resource, (object) ((CollectSamplingDataHistory) obj)._Resource)) && object.Equals((object) this._Product, (object) ((CollectSamplingDataHistory) obj)._Product)) && base.Equals(obj);
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

    public CollectSamplingHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CollectSamplingHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<int> AllowedRejects
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> TotalPassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalPassedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalPassedSamples));
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

    public Primitive<int> RequiredSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RequiredSamples));
      }
    }

    public Primitive<DateTime> TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Primitive<int> TotalSamplesCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCompleted), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalSamplesCompleted));
      }
    }

    public Primitive<string> SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public Primitive<int> TotalRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalRejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalRejects));
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
  }
}
