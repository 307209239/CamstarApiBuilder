// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointHistoryDetail_Environment
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
  public class DataPointHistoryDetail_Environment : ParametricDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected Environment _DataType;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DataCollectionDef")]
    protected new Environment _DataCollectionDef;
    [Metadata("DecimalValue allowing both precision and scale.", "", false, false, true, "String", 1050541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DecimalValue")]
    protected Environment _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPoint", false, false, true, "NamedSubentityRef", 1050537, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DataPoint")]
    protected Environment _DataPoint;
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_AttributeName")]
    protected Environment _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_RDOValue")]
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, true, "RevisionedObjectRef", 1050880, false, false, false, null)]
    protected Environment _RDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_LowerLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1050533, false, false, false, null)]
    protected Environment _LowerLimit;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049135, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_IntegerValue")]
    protected Environment _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_TimestampValue")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050543, false, false, false, null)]
    protected Environment _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_BooleanValue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049126, false, false, false, "0")]
    protected Environment _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_MapToUserAttribute")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051935, false, false, false, "0")]
    protected Environment _MapToUserAttribute;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_IsRequired")]
    protected Environment _IsRequired;
    [Metadata("Generic String", "", false, false, true, "String", 1050538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DataValue")]
    protected Environment _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_IsLimitOverrideAllowed")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050544, false, false, false, "0")]
    protected Environment _IsLimitOverrideAllowed;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050539, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_IsLimitOverride")]
    protected Environment _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_NDOValue")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, true, "NamedObjectRef", 1050879, false, false, false, null)]
    protected Environment _NDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_EnumerationValue")]
    [Metadata("Generic String", "", false, false, true, "String", 1050870, false, false, false, null)]
    protected Environment _EnumerationValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_FloatValue")]
    [Metadata("Generic Float", "", false, false, true, "Float", 1050542, false, false, false, null)]
    protected Environment _FloatValue;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050540, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_IsLimitViolation")]
    protected Environment _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_FixedValue")]
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049131, false, false, false, null)]
    protected Environment _FixedValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_UpperLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1050532, false, false, false, null)]
    protected Environment _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_ObjectTypeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050572, false, false, false, null)]
    protected Environment _ObjectTypeName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_DataName")]
    protected Environment _DataName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Environment_Comments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;

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

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
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
  }
}
