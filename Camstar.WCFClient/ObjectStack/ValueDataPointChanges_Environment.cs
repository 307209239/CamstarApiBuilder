// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ValueDataPointChanges_Environment
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
  public class ValueDataPointChanges_Environment : DataPointChanges_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1050532, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_UpperLimit")]
    protected Environment _UpperLimit;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Identifies additional information for a non-object data type.", "ValueDataPoint", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_DataType")]
    protected new Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_LowerLimit")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1050533, false, false, false, null)]
    protected Environment _LowerLimit;
    [Metadata("Identifies additional information for a non-object data type.", "ValueDataPointChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_AttributeName")]
    protected Environment _AttributeName;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052103, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_MapToUserAttribute")]
    protected Environment _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_BooleanTrue")]
    [Metadata("Generic String", "", false, false, false, "String", 1049148, false, false, false, null)]
    protected Environment _BooleanTrue;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050535, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_DisplayLimits")]
    protected Environment _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_BooleanFalse")]
    [Metadata("Generic String", "", false, false, false, "String", 16779390, false, false, false, null)]
    protected Environment _BooleanFalse;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050544, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Environment_IsLimitOverrideAllowed")]
    protected Environment _IsLimitOverrideAllowed;

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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment DataType
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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
  }
}
