// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingData_Info
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
  public class CollectSamplingData_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_ChangeQty")]
    protected ChangeQty_Info _ChangeQty;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_RejectReasons")]
    protected Info _RejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_ServiceDetails")]
    protected CollectSamplingDataDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_ContainerSampleData")]
    protected ContainerSampleData_Info _ContainerSampleData;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_SamplingStatus")]
    protected Info _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_ContainerSampleDataItem")]
    protected Info _ContainerSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_AQLLevel")]
    protected Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_CollectSamplingDataPoints")]
    protected CollectSamplingDataPoints_Info _CollectSamplingDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_CreateProductionEvent")]
    protected CreateProductionEvent_Info _CreateProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_InspectionLevel")]
    protected Info _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_SampleType")]
    protected Info _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_AllowedRejects")]
    protected Info _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_RequiredSamples")]
    protected Info _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_TotalSampleCompleted")]
    protected Info _TotalSampleCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_PassedSamples")]
    protected Info _PassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_AcceptableRejectCount")]
    protected Info _AcceptableRejectCount;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_SamplesTested")]
    protected Info _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_FailedSamples")]
    protected Info _FailedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Info_Product")]
    protected Info _Product;

    public ChangeQty_Info ChangeQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQty), (object) value);
      }
      get
      {
        return (ChangeQty_Info) this.PropertyGet(nameof (ChangeQty));
      }
    }

    public Info RejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RejectReasons));
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

    public CollectSamplingDataDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CollectSamplingDataDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public ContainerSampleData_Info ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (ContainerSampleData_Info) this.PropertyGet(nameof (ContainerSampleData));
      }
    }

    public new Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Info SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public Info ContainerSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleDataItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerSampleDataItem));
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

    public CollectSamplingDataPoints_Info CollectSamplingDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingDataPoints), (object) value);
      }
      get
      {
        return (CollectSamplingDataPoints_Info) this.PropertyGet(nameof (CollectSamplingDataPoints));
      }
    }

    public CreateProductionEvent_Info CreateProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateProductionEvent), (object) value);
      }
      get
      {
        return (CreateProductionEvent_Info) this.PropertyGet(nameof (CreateProductionEvent));
      }
    }

    public Info SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTest));
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

    public Info SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleType));
      }
    }

    public Info AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info RequiredSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequiredSamples));
      }
    }

    public Info TotalSampleCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSampleCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalSampleCompleted));
      }
    }

    public Info PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Info AcceptableRejectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcceptableRejectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AcceptableRejectCount));
      }
    }

    public Info SamplesTested
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesTested), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplesTested));
      }
    }

    public Info FailedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailedSamples));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
