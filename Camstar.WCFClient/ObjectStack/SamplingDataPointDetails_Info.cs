// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingDataPointDetails_Info
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
  public class SamplingDataPointDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Info_RejectReason")]
    protected Info _RejectReason;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Info_SampleDataPoint")]
    protected Info _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Info_Passed")]
    protected Info _Passed;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Info_DataValue")]
    protected Info _DataValue;

    public Info RejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RejectReason));
      }
    }

    public Info SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Info Passed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Passed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Passed));
      }
    }

    public Info DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataValue));
      }
    }
  }
}
