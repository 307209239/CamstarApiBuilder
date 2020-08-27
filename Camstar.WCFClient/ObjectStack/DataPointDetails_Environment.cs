// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointDetails_Environment
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
  public class DataPointDetails_Environment : ParametricData_Environment
  {
    [Metadata("DecimalValue allowing both precision and scale.", "", false, false, true, "String", 1050541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DecimalValue")]
    protected Environment _DecimalValue;
    [Metadata("Identifies the type of the Control Display Mode\r\n1 = DropDown\r\n2 = PickList\r\n4 = None", "ControlDisplayModeEnum", false, false, true, "Integer", 1050521, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DisplayMode")]
    protected Environment _DisplayMode;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DataType")]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DataPoint")]
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPoint", false, true, false, "NamedSubentityRef", 1050537, false, false, true, null)]
    protected Environment _DataPoint;
    [Metadata("Identifies the type of object for the Data Point Collection Def\r\n1 = NDO\r\n2 = RDO\r\n5 = Enumeration", "ObjectRefTypeEnum", false, false, true, "Integer", 1050567, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_ObjectRefType")]
    protected Environment _ObjectRefType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_AttributeName")]
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    protected Environment _AttributeName;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050529, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_ColumnPosition")]
    protected Environment _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DataValue")]
    [Metadata("Generic String", "", false, false, false, "String", 1050538, false, false, true, null)]
    protected Environment _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_BooleanTrue")]
    [Metadata("Generic String", "", false, false, false, "String", 16779391, false, false, false, null)]
    protected Environment _BooleanTrue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_UpperLimit")]
    [Metadata("Generic String", "", false, false, false, "String", 1050532, false, false, false, null)]
    protected Environment _UpperLimit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050892, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_IsLimitOverride")]
    protected Environment _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_IsRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049018, false, false, false, "0")]
    protected Environment _IsRequired;
    [Metadata("Generic String", "", false, false, false, "String", 1050533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_LowerLimit")]
    protected Environment _LowerLimit;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049135, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_IntegerValue")]
    protected Environment _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_EnumerationValue")]
    [Metadata("Generic String", "", false, false, true, "String", 1050870, false, false, false, null)]
    protected Environment _EnumerationValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_IsLimitOverrideAllowed")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050544, false, false, false, "0")]
    protected Environment _IsLimitOverrideAllowed;
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049131, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_FixedValue")]
    protected Environment _FixedValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_FloatValue")]
    [Metadata("Generic Float", "", false, false, true, "Float", 1050542, false, false, false, null)]
    protected Environment _FloatValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DisplayLimits")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050535, false, false, false, "0")]
    protected Environment _DisplayLimits;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050530, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_RowPosition")]
    protected Environment _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_TimestampValue")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050543, false, false, false, null)]
    protected Environment _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_RDOValue")]
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 1050880, false, false, true, null)]
    protected Environment _RDOValue;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050540, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_IsLimitViolation")]
    protected Environment _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_NDOValue")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1050879, false, false, true, null)]
    protected Environment _NDOValue;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049126, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_BooleanValue")]
    protected Environment _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_MapToUserAttribute")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051935, false, false, false, "0")]
    protected Environment _MapToUserAttribute;
    [Metadata("Generic String", "", false, false, false, "String", 1049147, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_BooleanFalse")]
    protected Environment _BooleanFalse;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_Comments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_DataName")]
    protected Environment _DataName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointDetails_Environment_ObjectValueCDOType")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050572, false, false, false, null)]
    protected Environment _ObjectValueCDOType;

    public Environment DecimalValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecimalValue));
      }
    }

    public Environment DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Environment ObjectRefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRefType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRefType));
      }
    }

    public Environment AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Environment ColumnPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ColumnPosition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ColumnPosition));
      }
    }

    public Environment DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataValue));
      }
    }

    public Environment BooleanTrue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanTrue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BooleanTrue));
      }
    }

    public Environment UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Environment IsLimitOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitOverride));
      }
    }

    public Environment IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Environment LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Environment IntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IntegerValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IntegerValue));
      }
    }

    public Environment EnumerationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnumerationValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnumerationValue));
      }
    }

    public Environment IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Environment FixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FixedValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FixedValue));
      }
    }

    public Environment FloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FloatValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FloatValue));
      }
    }

    public Environment DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Environment RowPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (RowPosition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RowPosition));
      }
    }

    public Environment TimestampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimestampValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimestampValue));
      }
    }

    public Environment RDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDOValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RDOValue));
      }
    }

    public Environment IsLimitViolation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitViolation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitViolation));
      }
    }

    public Environment NDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDOValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NDOValue));
      }
    }

    public Environment BooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BooleanValue));
      }
    }

    public Environment MapToUserAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToUserAttribute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MapToUserAttribute));
      }
    }

    public Environment BooleanFalse
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanFalse), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BooleanFalse));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment DataName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataName));
      }
    }

    public Environment ObjectValueCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectValueCDOType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectValueCDOType));
      }
    }
  }
}
