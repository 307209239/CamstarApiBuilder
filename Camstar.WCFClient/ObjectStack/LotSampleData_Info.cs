// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotSampleData_Info
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
  public class LotSampleData_Info : ContainerSampleData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_SampleTest")]
    protected new Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_AQLLevel")]
    protected new Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_InspectionLevel")]
    protected new Info _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_SamplingPlanDetail")]
    protected Info _SamplingPlanDetail;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_SamplesFailed")]
    protected Info _SamplesFailed;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_InspectAllContQty")]
    protected new Info _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_SamplesTested")]
    protected Info _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_Rejects")]
    protected new Info _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_TotalSamplesRequired")]
    protected new Info _TotalSamplesRequired;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_InspectAllQtyOnFailure")]
    protected new Info _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_AllowedRejects")]
    protected new Info _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_CompletedSamples")]
    protected new Info _CompletedSamples;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Info_Resource")]
    protected Info _Resource;

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

    public new Info SampleTest
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

    public new Info AQLLevel
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

    public new Info InspectionLevel
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

    public Info SamplingPlanDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlanDetail));
      }
    }

    public Info SamplesFailed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesFailed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplesFailed));
      }
    }

    public new Info InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectAllContQty));
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

    public new Info Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejects));
      }
    }

    public new Info TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public new Info InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public new Info AllowedRejects
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

    public new Info CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletedSamples));
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
  }
}
