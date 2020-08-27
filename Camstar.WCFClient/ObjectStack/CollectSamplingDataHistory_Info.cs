// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CollectLotSamplingDataHistory_Info))]
  [Serializable]
  public class CollectSamplingDataHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_HistoryDetails")]
    protected CollectSamplingHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_InspectionLevel")]
    protected Info _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_AQLLevel")]
    protected Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_AllowedRejects")]
    protected Info _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_TotalPassedSamples")]
    protected Info _TotalPassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_SamplesTested")]
    protected Info _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_RequiredSamples")]
    protected Info _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_TxnDateGMT")]
    protected Info _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_TotalSamplesCompleted")]
    protected Info _TotalSamplesCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_SamplingStatus")]
    protected Info _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_TotalRejects")]
    protected Info _TotalRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Info_Product")]
    protected Info _Product;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public CollectSamplingHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CollectSamplingHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info SamplingPlan
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info TotalPassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalPassedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalPassedSamples));
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

    public Info TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Info TotalSamplesCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalSamplesCompleted));
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

    public Info TotalRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalRejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalRejects));
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
