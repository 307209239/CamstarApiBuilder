// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleHistory
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
  public class DPCollectionSampleHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_DecimalValue")]
    protected Primitive<string> _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_DataPointCollectionRangeColor")]
    protected Enumeration<DPCollectionRangeColorEnum, int> _DataPointCollectionRangeColor;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_CellName")]
    protected Primitive<string> _CellName;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_BooleanValue")]
    protected Primitive<bool> _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_IntegerValue")]
    protected Primitive<int> _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_TimestampValue")]
    protected Primitive<DateTime> _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionSampleHistory && object.Equals((object) this._DecimalValue, (object) ((DPCollectionSampleHistory) obj)._DecimalValue) && (object.Equals((object) this._ExportImportKey, (object) ((DPCollectionSampleHistory) obj)._ExportImportKey) && object.Equals((object) this._DataPointCollectionRangeColor, (object) ((DPCollectionSampleHistory) obj)._DataPointCollectionRangeColor)) && (object.Equals((object) this._DataValue, (object) ((DPCollectionSampleHistory) obj)._DataValue) && object.Equals((object) this._CellName, (object) ((DPCollectionSampleHistory) obj)._CellName) && (object.Equals((object) this._BooleanValue, (object) ((DPCollectionSampleHistory) obj)._BooleanValue) && object.Equals((object) this._IntegerValue, (object) ((DPCollectionSampleHistory) obj)._IntegerValue))) && (object.Equals((object) this._TimestampValue, (object) ((DPCollectionSampleHistory) obj)._TimestampValue) && object.Equals((object) this._HistoryId, (object) ((DPCollectionSampleHistory) obj)._HistoryId)) && base.Equals(obj);
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
  }
}
