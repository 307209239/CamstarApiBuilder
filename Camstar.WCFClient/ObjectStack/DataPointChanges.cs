// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ObjectDataPointChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointCollectionPointChgs))]
  [KnownType(typeof (ValueDataPointChanges))]
  [Serializable]
  public class DataPointChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_ColumnPosition")]
    protected Primitive<int> _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_RowPosition")]
    protected Primitive<int> _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DataPointChanges && object.Equals((object) this._ObjectToChange, (object) ((DataPointChanges) obj)._ObjectToChange) && (object.Equals((object) this._DataType, (object) ((DataPointChanges) obj)._DataType) && object.Equals((object) this._ListItemToChange, (object) ((DataPointChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ColumnPosition, (object) ((DataPointChanges) obj)._ColumnPosition) && object.Equals((object) this._IsRequired, (object) ((DataPointChanges) obj)._IsRequired) && (object.Equals((object) this._RowPosition, (object) ((DataPointChanges) obj)._RowPosition) && object.Equals((object) this._Name, (object) ((DataPointChanges) obj)._Name))) && base.Equals(obj);
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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
  }
}
