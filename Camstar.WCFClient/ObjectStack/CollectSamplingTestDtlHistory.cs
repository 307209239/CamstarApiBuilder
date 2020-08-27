// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingTestDtlHistory
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
  public class CollectSamplingTestDtlHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_RejectReason")]
    protected NamedObjectRef _RejectReason;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_SampleDataPoint")]
    protected RevisionedObjectRef _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Passed")]
    protected Primitive<bool> _Passed;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingTestDtlHistory && object.Equals((object) this._RejectReason, (object) ((CollectSamplingTestDtlHistory) obj)._RejectReason) && (object.Equals((object) this._ExportImportKey, (object) ((CollectSamplingTestDtlHistory) obj)._ExportImportKey) && object.Equals((object) this._SampleDataPoint, (object) ((CollectSamplingTestDtlHistory) obj)._SampleDataPoint)) && (object.Equals((object) this._DataType, (object) ((CollectSamplingTestDtlHistory) obj)._DataType) && object.Equals((object) this._DataValue, (object) ((CollectSamplingTestDtlHistory) obj)._DataValue) && (object.Equals((object) this._UpperLimit, (object) ((CollectSamplingTestDtlHistory) obj)._UpperLimit) && object.Equals((object) this._LowerLimit, (object) ((CollectSamplingTestDtlHistory) obj)._LowerLimit))) && (object.Equals((object) this._Passed, (object) ((CollectSamplingTestDtlHistory) obj)._Passed) && object.Equals((object) this._HistoryId, (object) ((CollectSamplingTestDtlHistory) obj)._HistoryId)) && base.Equals(obj);
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

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
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

    public Primitive<string> UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Primitive<string> LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LowerLimit));
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
