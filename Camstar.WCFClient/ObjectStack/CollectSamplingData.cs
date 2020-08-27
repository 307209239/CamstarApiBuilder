// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingData
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
  public class CollectSamplingData : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_ChangeQty")]
    protected ChangeQty _ChangeQty;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_RejectReasons")]
    protected NamedObjectRef _RejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_ServiceDetails")]
    protected CollectSamplingDataDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_ContainerSampleData")]
    protected Camstar.WCF.ObjectStack.ContainerSampleData[] _ContainerSampleData;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_SamplingStatus")]
    protected Enumeration<SampleStatusEnum, string> _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_ContainerSampleDataItem")]
    protected SubentityRef _ContainerSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_CollectSamplingDataPoints")]
    protected Camstar.WCF.ObjectStack.CollectSamplingDataPoints[] _CollectSamplingDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_CreateProductionEvent")]
    protected CreateProductionEvent _CreateProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_InspectionLevel")]
    protected NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_SampleType")]
    protected Enumeration<SampleTypeEnum, int> _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_AllowedRejects")]
    protected Primitive<int> _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_RequiredSamples")]
    protected Primitive<int> _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_TotalSampleCompleted")]
    protected Primitive<int> _TotalSampleCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_PassedSamples")]
    protected Primitive<int> _PassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_AcceptableRejectCount")]
    protected Primitive<int> _AcceptableRejectCount;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_SamplesTested")]
    protected Primitive<int> _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_FailedSamples")]
    protected Primitive<int> _FailedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingData && object.Equals((object) this._ChangeQty, (object) ((CollectSamplingData) obj)._ChangeQty) && (object.Equals((object) this._RejectReasons, (object) ((CollectSamplingData) obj)._RejectReasons) && object.Equals((object) this._VendorItem, (object) ((CollectSamplingData) obj)._VendorItem)) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((CollectSamplingData) obj)._ServiceDetails) && this.CompareArrays((Array) this._ContainerSampleData, (Array) ((CollectSamplingData) obj)._ContainerSampleData) && (object.Equals((object) this._SamplingPlan, (object) ((CollectSamplingData) obj)._SamplingPlan) && object.Equals((object) this._SamplingStatus, (object) ((CollectSamplingData) obj)._SamplingStatus))) && (object.Equals((object) this._ContainerSampleDataItem, (object) ((CollectSamplingData) obj)._ContainerSampleDataItem) && object.Equals((object) this._AQLLevel, (object) ((CollectSamplingData) obj)._AQLLevel) && (this.CompareArrays((Array) this._CollectSamplingDataPoints, (Array) ((CollectSamplingData) obj)._CollectSamplingDataPoints) && object.Equals((object) this._CreateProductionEvent, (object) ((CollectSamplingData) obj)._CreateProductionEvent)) && (object.Equals((object) this._SampleTest, (object) ((CollectSamplingData) obj)._SampleTest) && object.Equals((object) this._InspectionLevel, (object) ((CollectSamplingData) obj)._InspectionLevel) && (object.Equals((object) this._SampleType, (object) ((CollectSamplingData) obj)._SampleType) && object.Equals((object) this._AllowedRejects, (object) ((CollectSamplingData) obj)._AllowedRejects)))) && (object.Equals((object) this._Container, (object) ((CollectSamplingData) obj)._Container) && object.Equals((object) this._RequiredSamples, (object) ((CollectSamplingData) obj)._RequiredSamples) && (object.Equals((object) this._TotalSampleCompleted, (object) ((CollectSamplingData) obj)._TotalSampleCompleted) && object.Equals((object) this._PassedSamples, (object) ((CollectSamplingData) obj)._PassedSamples)) && (object.Equals((object) this._ProcessESignatures, (object) ((CollectSamplingData) obj)._ProcessESignatures) && object.Equals((object) this._AcceptableRejectCount, (object) ((CollectSamplingData) obj)._AcceptableRejectCount) && (object.Equals((object) this._SamplesTested, (object) ((CollectSamplingData) obj)._SamplesTested) && object.Equals((object) this._FailedSamples, (object) ((CollectSamplingData) obj)._FailedSamples))) && object.Equals((object) this._Product, (object) ((CollectSamplingData) obj)._Product)) && base.Equals(obj);
    }

    public ChangeQty ChangeQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQty), (object) value);
      }
      get
      {
        return (ChangeQty) this.PropertyGet(nameof (ChangeQty));
      }
    }

    public NamedObjectRef RejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RejectReasons));
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

    public CollectSamplingDataDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CollectSamplingDataDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Camstar.WCF.ObjectStack.ContainerSampleData[] ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ContainerSampleData[]) this.PropertyGet(nameof (ContainerSampleData));
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

    public Enumeration<SampleStatusEnum, string> SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Enumeration<SampleStatusEnum, string>) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public SubentityRef ContainerSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleDataItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ContainerSampleDataItem));
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

    public Camstar.WCF.ObjectStack.CollectSamplingDataPoints[] CollectSamplingDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingDataPoints), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.CollectSamplingDataPoints[]) this.PropertyGet(nameof (CollectSamplingDataPoints));
      }
    }

    public CreateProductionEvent CreateProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateProductionEvent), (object) value);
      }
      get
      {
        return (CreateProductionEvent) this.PropertyGet(nameof (CreateProductionEvent));
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

    public Enumeration<SampleTypeEnum, int> SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Enumeration<SampleTypeEnum, int>) this.PropertyGet(nameof (SampleType));
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

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public Primitive<int> TotalSampleCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSampleCompleted), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalSampleCompleted));
      }
    }

    public Primitive<int> PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Primitive<int> AcceptableRejectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcceptableRejectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AcceptableRejectCount));
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

    public Primitive<int> FailedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FailedSamples));
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
