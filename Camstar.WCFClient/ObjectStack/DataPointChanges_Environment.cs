// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ValueDataPointChanges_Environment))]
  [KnownType(typeof (DataPointCollectionPointChgs_Environment))]
  [KnownType(typeof (ObjectDataPointChanges_Environment))]
  [Serializable]
  public class DataPointChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_ObjectToChange")]
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPoint", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    protected Environment _DataType;
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPointChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_ColumnPosition")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050529, false, false, false, null)]
    protected Environment _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_IsRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049018, false, false, false, "0")]
    protected Environment _IsRequired;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050530, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_RowPosition")]
    protected Environment _RowPosition;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
