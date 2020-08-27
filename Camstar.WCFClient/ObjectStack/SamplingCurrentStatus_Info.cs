// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingCurrentStatus_Info
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
  public class SamplingCurrentStatus_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_AQLLevel")]
    protected Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_SamplePlanInspectionLevel")]
    protected Info _SamplePlanInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_CurrentInspectionLevel")]
    protected Info _CurrentInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_LastUpdateDate")]
    protected Info _LastUpdateDate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_SampleRateCounter")]
    protected Info _SampleRateCounter;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_CurrentSampleRate")]
    protected Info _CurrentSampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Info_Resource")]
    protected Info _Resource;

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

    public Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Info SamplePlanInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplePlanInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplePlanInspectionLevel));
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

    public Info CurrentInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentInspectionLevel));
      }
    }

    public Info LastUpdateDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdateDate));
      }
    }

    public Info SampleRateCounter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateCounter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRateCounter));
      }
    }

    public Info CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentSampleRate));
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
