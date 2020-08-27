// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointCollectionPointChgs_Info))]
  [KnownType(typeof (ValueDataPointChanges_Info))]
  [KnownType(typeof (ObjectDataPointChanges_Info))]
  [Serializable]
  public class DataPointChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_ColumnPosition")]
    protected Info _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_RowPosition")]
    protected Info _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPointChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info ColumnPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ColumnPosition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ColumnPosition));
      }
    }

    public Info IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Info RowPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (RowPosition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RowPosition));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
