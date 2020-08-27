// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPoint
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointCollectionPoint))]
  [Serializable]
  public class DataPoint : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_ColumnPosition")]
    protected Primitive<int> _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_RowPosition")]
    protected Primitive<int> _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DataPoint && object.Equals((object) this._DataType, (object) ((DataPoint) obj)._DataType) && (object.Equals((object) this._ExportImportKey, (object) ((DataPoint) obj)._ExportImportKey) && object.Equals((object) this._IsRequired, (object) ((DataPoint) obj)._IsRequired)) && (object.Equals((object) this._ColumnPosition, (object) ((DataPoint) obj)._ColumnPosition) && object.Equals((object) this._RowPosition, (object) ((DataPoint) obj)._RowPosition) && (object.Equals((object) this._Name, (object) ((DataPoint) obj)._Name) && object.Equals((object) this._IsFrozen, (object) ((DataPoint) obj)._IsFrozen))) && base.Equals(obj);
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

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
