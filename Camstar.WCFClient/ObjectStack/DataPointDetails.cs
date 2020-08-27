// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointDetails
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
  public class DataPointDetails : ParametricData
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DecimalValue")]
    protected Primitive<string> _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DisplayMode")]
    protected Enumeration<ControlDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DataPoint")]
    protected NamedSubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_ObjectRefType")]
    protected Enumeration<ObjectRefTypeEnum, int> _ObjectRefType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_ColumnPosition")]
    protected Primitive<int> _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_BooleanTrue")]
    protected Primitive<string> _BooleanTrue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_IsLimitOverride")]
    protected Primitive<bool> _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_IntegerValue")]
    protected Primitive<int> _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_EnumerationValue")]
    protected Primitive<string> _EnumerationValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_FixedValue")]
    protected Primitive<double> _FixedValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_FloatValue")]
    protected Primitive<double> _FloatValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DisplayLimits")]
    protected Primitive<bool> _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_RowPosition")]
    protected Primitive<int> _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_TimestampValue")]
    protected Primitive<DateTime> _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_RDOValue")]
    protected RevisionedObjectRef _RDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_IsLimitViolation")]
    protected Primitive<bool> _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_NDOValue")]
    protected NamedObjectRef _NDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_BooleanValue")]
    protected Primitive<bool> _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_MapToUserAttribute")]
    protected Primitive<bool> _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_BooleanFalse")]
    protected Primitive<string> _BooleanFalse;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_DataName")]
    protected Primitive<string> _DataName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_ObjectValueCDOType")]
    protected Primitive<string> _ObjectValueCDOType;

    public override bool Equals(object obj)
    {
      return obj is DataPointDetails && object.Equals((object) this._DecimalValue, (object) ((DataPointDetails) obj)._DecimalValue) && (object.Equals((object) this._DisplayMode, (object) ((DataPointDetails) obj)._DisplayMode) && object.Equals((object) this._DataType, (object) ((DataPointDetails) obj)._DataType)) && (object.Equals((object) this._UOM, (object) ((DataPointDetails) obj)._UOM) && object.Equals((object) this._DataPoint, (object) ((DataPointDetails) obj)._DataPoint) && (object.Equals((object) this._ObjectRefType, (object) ((DataPointDetails) obj)._ObjectRefType) && object.Equals((object) this._AttributeName, (object) ((DataPointDetails) obj)._AttributeName))) && (object.Equals((object) this._ColumnPosition, (object) ((DataPointDetails) obj)._ColumnPosition) && object.Equals((object) this._DataValue, (object) ((DataPointDetails) obj)._DataValue) && (object.Equals((object) this._BooleanTrue, (object) ((DataPointDetails) obj)._BooleanTrue) && object.Equals((object) this._UpperLimit, (object) ((DataPointDetails) obj)._UpperLimit)) && (object.Equals((object) this._IsLimitOverride, (object) ((DataPointDetails) obj)._IsLimitOverride) && object.Equals((object) this._IsRequired, (object) ((DataPointDetails) obj)._IsRequired) && (object.Equals((object) this._LowerLimit, (object) ((DataPointDetails) obj)._LowerLimit) && object.Equals((object) this._IntegerValue, (object) ((DataPointDetails) obj)._IntegerValue)))) && (object.Equals((object) this._EnumerationValue, (object) ((DataPointDetails) obj)._EnumerationValue) && object.Equals((object) this._IsLimitOverrideAllowed, (object) ((DataPointDetails) obj)._IsLimitOverrideAllowed) && (object.Equals((object) this._FixedValue, (object) ((DataPointDetails) obj)._FixedValue) && object.Equals((object) this._FloatValue, (object) ((DataPointDetails) obj)._FloatValue)) && (object.Equals((object) this._DisplayLimits, (object) ((DataPointDetails) obj)._DisplayLimits) && object.Equals((object) this._RowPosition, (object) ((DataPointDetails) obj)._RowPosition) && (object.Equals((object) this._TimestampValue, (object) ((DataPointDetails) obj)._TimestampValue) && object.Equals((object) this._RDOValue, (object) ((DataPointDetails) obj)._RDOValue))) && (object.Equals((object) this._IsLimitViolation, (object) ((DataPointDetails) obj)._IsLimitViolation) && object.Equals((object) this._NDOValue, (object) ((DataPointDetails) obj)._NDOValue) && (object.Equals((object) this._BooleanValue, (object) ((DataPointDetails) obj)._BooleanValue) && object.Equals((object) this._MapToUserAttribute, (object) ((DataPointDetails) obj)._MapToUserAttribute)) && (object.Equals((object) this._BooleanFalse, (object) ((DataPointDetails) obj)._BooleanFalse) && object.Equals((object) this._Comments, (object) ((DataPointDetails) obj)._Comments) && (object.Equals((object) this._DataName, (object) ((DataPointDetails) obj)._DataName) && object.Equals((object) this._ObjectValueCDOType, (object) ((DataPointDetails) obj)._ObjectValueCDOType))))) && base.Equals(obj);
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

    public Enumeration<ControlDisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<ControlDisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
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

    public Enumeration<ObjectRefTypeEnum, int> ObjectRefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRefType), (object) value);
      }
      get
      {
        return (Enumeration<ObjectRefTypeEnum, int>) this.PropertyGet(nameof (ObjectRefType));
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

    public Primitive<int> ColumnPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ColumnPosition), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ColumnPosition));
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

    public Primitive<string> BooleanTrue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanTrue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BooleanTrue));
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

    public Primitive<bool> DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Primitive<int> RowPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (RowPosition), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RowPosition));
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

    public Primitive<string> BooleanFalse
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanFalse), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BooleanFalse));
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

    public Primitive<string> ObjectValueCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectValueCDOType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectValueCDOType));
      }
    }
  }
}
