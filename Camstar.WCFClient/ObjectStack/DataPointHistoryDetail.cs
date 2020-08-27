// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointHistoryDetail
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
  public class DataPointHistoryDetail : ParametricDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DecimalValue")]
    protected Primitive<string> _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DataPoint")]
    protected NamedSubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_RDOValue")]
    protected RevisionedObjectRef _RDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_IntegerValue")]
    protected Primitive<int> _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_TimestampValue")]
    protected Primitive<DateTime> _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_BooleanValue")]
    protected Primitive<bool> _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_MapToUserAttribute")]
    protected Primitive<bool> _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_IsLimitOverride")]
    protected Primitive<bool> _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_NDOValue")]
    protected NamedObjectRef _NDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_EnumerationValue")]
    protected Primitive<string> _EnumerationValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_FloatValue")]
    protected Primitive<double> _FloatValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_IsLimitViolation")]
    protected Primitive<bool> _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_FixedValue")]
    protected Primitive<double> _FixedValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_DataName")]
    protected Primitive<string> _DataName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Comments")]
    protected Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is DataPointHistoryDetail && object.Equals((object) this._DataType, (object) ((DataPointHistoryDetail) obj)._DataType) && (object.Equals((object) this._DataCollectionDef, (object) ((DataPointHistoryDetail) obj)._DataCollectionDef) && object.Equals((object) this._DecimalValue, (object) ((DataPointHistoryDetail) obj)._DecimalValue)) && (object.Equals((object) this._UOM, (object) ((DataPointHistoryDetail) obj)._UOM) && object.Equals((object) this._ExportImportKey, (object) ((DataPointHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._DataPoint, (object) ((DataPointHistoryDetail) obj)._DataPoint) && object.Equals((object) this._AttributeName, (object) ((DataPointHistoryDetail) obj)._AttributeName))) && (object.Equals((object) this._RDOValue, (object) ((DataPointHistoryDetail) obj)._RDOValue) && object.Equals((object) this._LowerLimit, (object) ((DataPointHistoryDetail) obj)._LowerLimit) && (object.Equals((object) this._IntegerValue, (object) ((DataPointHistoryDetail) obj)._IntegerValue) && object.Equals((object) this._TimestampValue, (object) ((DataPointHistoryDetail) obj)._TimestampValue)) && (object.Equals((object) this._BooleanValue, (object) ((DataPointHistoryDetail) obj)._BooleanValue) && object.Equals((object) this._MapToUserAttribute, (object) ((DataPointHistoryDetail) obj)._MapToUserAttribute) && (object.Equals((object) this._IsRequired, (object) ((DataPointHistoryDetail) obj)._IsRequired) && object.Equals((object) this._DataValue, (object) ((DataPointHistoryDetail) obj)._DataValue)))) && (object.Equals((object) this._IsLimitOverrideAllowed, (object) ((DataPointHistoryDetail) obj)._IsLimitOverrideAllowed) && object.Equals((object) this._IsLimitOverride, (object) ((DataPointHistoryDetail) obj)._IsLimitOverride) && (object.Equals((object) this._NDOValue, (object) ((DataPointHistoryDetail) obj)._NDOValue) && object.Equals((object) this._EnumerationValue, (object) ((DataPointHistoryDetail) obj)._EnumerationValue)) && (object.Equals((object) this._FloatValue, (object) ((DataPointHistoryDetail) obj)._FloatValue) && object.Equals((object) this._IsLimitViolation, (object) ((DataPointHistoryDetail) obj)._IsLimitViolation) && (object.Equals((object) this._FixedValue, (object) ((DataPointHistoryDetail) obj)._FixedValue) && object.Equals((object) this._HistoryId, (object) ((DataPointHistoryDetail) obj)._HistoryId))) && (object.Equals((object) this._UpperLimit, (object) ((DataPointHistoryDetail) obj)._UpperLimit) && object.Equals((object) this._ObjectTypeName, (object) ((DataPointHistoryDetail) obj)._ObjectTypeName) && (object.Equals((object) this._DataName, (object) ((DataPointHistoryDetail) obj)._DataName) && object.Equals((object) this._Comments, (object) ((DataPointHistoryDetail) obj)._Comments)))) && base.Equals(obj);
    }

    public Enumeration<DataTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
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

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
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

    public NamedSubentityRef DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Primitive<string> AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeName));
      }
    }

    public RevisionedObjectRef RDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDOValue), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RDOValue));
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

    public Primitive<bool> MapToUserAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToUserAttribute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MapToUserAttribute));
      }
    }

    public Primitive<bool> IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRequired));
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

    public Primitive<bool> IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Primitive<bool> IsLimitOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitOverride));
      }
    }

    public NamedObjectRef NDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDOValue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NDOValue));
      }
    }

    public Primitive<string> EnumerationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnumerationValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EnumerationValue));
      }
    }

    public Primitive<double> FloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FloatValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FloatValue));
      }
    }

    public Primitive<bool> IsLimitViolation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitViolation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitViolation));
      }
    }

    public Primitive<double> FixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FixedValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FixedValue));
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

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Primitive<string> DataName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataName));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
