// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentSamplingStatusUpdate_Info
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
  public class CurrentSamplingStatusUpdate_Info : GenericTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_NewInspectionLevel")]
    protected Info _NewInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_ServiceDetails")]
    protected SamplingCurrentStatus_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_SamplingCurrentStatus")]
    protected SamplingCurrentStatus_Info _SamplingCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_NewSampleRateCounterValue")]
    protected Info _NewSampleRateCounterValue;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_ResetInspectionLevel")]
    protected Info _ResetInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Info_Product")]
    protected Info _Product;

    public Info NewInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewInspectionLevel));
      }
    }

    public SamplingCurrentStatus_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (SamplingCurrentStatus_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public SamplingCurrentStatus_Info SamplingCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingCurrentStatus), (object) value);
      }
      get
      {
        return (SamplingCurrentStatus_Info) this.PropertyGet(nameof (SamplingCurrentStatus));
      }
    }

    public Info NewSampleRateCounterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewSampleRateCounterValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewSampleRateCounterValue));
      }
    }

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info ResetInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResetInspectionLevel));
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
