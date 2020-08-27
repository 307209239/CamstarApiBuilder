// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingDataPointDetails
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
  public class SamplingDataPointDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_RejectReason")]
    protected NamedObjectRef _RejectReason;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_SampleDataPoint")]
    protected RevisionedObjectRef _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Passed")]
    protected Primitive<bool> _Passed;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_DataValue")]
    protected Primitive<string> _DataValue;

    public override bool Equals(object obj)
    {
      return obj is SamplingDataPointDetails && object.Equals((object) this._RejectReason, (object) ((SamplingDataPointDetails) obj)._RejectReason) && (object.Equals((object) this._SampleDataPoint, (object) ((SamplingDataPointDetails) obj)._SampleDataPoint) && object.Equals((object) this._Passed, (object) ((SamplingDataPointDetails) obj)._Passed)) && object.Equals((object) this._DataValue, (object) ((SamplingDataPointDetails) obj)._DataValue) && base.Equals(obj);
    }

    public NamedObjectRef RejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RejectReason));
      }
    }

    public RevisionedObjectRef SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Primitive<bool> Passed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Passed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Passed));
      }
    }

    public Primitive<string> DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataValue));
      }
    }
  }
}
