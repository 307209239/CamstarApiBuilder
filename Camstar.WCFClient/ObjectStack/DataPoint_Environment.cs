// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPoint_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointCollectionPoint_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DataPoint_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_IsRequired")]
    protected Environment _IsRequired;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050529, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_ColumnPosition")]
    protected Environment _ColumnPosition;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050530, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_RowPosition")]
    protected Environment _RowPosition;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
