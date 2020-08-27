// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleDetail
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
  public class DPCollectionSampleDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_DecimalValue")]
    protected Primitive<string> _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Sample")]
    protected NamedSubentityRef _Sample;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_DataPointCollectionRangeColor")]
    protected Enumeration<DPCollectionRangeColorEnum, int> _DataPointCollectionRangeColor;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_TimestampValue")]
    protected Primitive<DateTime> _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_BooleanValue")]
    protected Primitive<bool> _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_IntegerValue")]
    protected Primitive<int> _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_CellName")]
    protected Primitive<string> _CellName;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionSampleDetail && object.Equals((object) this._DecimalValue, (object) ((DPCollectionSampleDetail) obj)._DecimalValue) && (object.Equals((object) this._Sample, (object) ((DPCollectionSampleDetail) obj)._Sample) && object.Equals((object) this._DataPointCollectionRangeColor, (object) ((DPCollectionSampleDetail) obj)._DataPointCollectionRangeColor)) && (object.Equals((object) this._TimestampValue, (object) ((DPCollectionSampleDetail) obj)._TimestampValue) && object.Equals((object) this._DataValue, (object) ((DPCollectionSampleDetail) obj)._DataValue) && (object.Equals((object) this._BooleanValue, (object) ((DPCollectionSampleDetail) obj)._BooleanValue) && object.Equals((object) this._IntegerValue, (object) ((DPCollectionSampleDetail) obj)._IntegerValue))) && object.Equals((object) this._CellName, (object) ((DPCollectionSampleDetail) obj)._CellName) && base.Equals(obj);
    }

    public Primitive<string> DecimalValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DecimalValue));
      }
    }

    public NamedSubentityRef Sample
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sample), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Sample));
      }
    }

    public Enumeration<DPCollectionRangeColorEnum, int> DataPointCollectionRangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollectionRangeColor), (object) value);
      }
      get
      {
        return (Enumeration<DPCollectionRangeColorEnum, int>) this.PropertyGet(nameof (DataPointCollectionRangeColor));
      }
    }

    public Primitive<DateTime> TimestampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimestampValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TimestampValue));
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

    public Primitive<bool> BooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanValue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BooleanValue));
      }
    }

    public Primitive<int> IntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IntegerValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IntegerValue));
      }
    }

    public Primitive<string> CellName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CellName));
      }
    }
  }
}
