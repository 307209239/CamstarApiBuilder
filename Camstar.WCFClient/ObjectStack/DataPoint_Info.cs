// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPoint_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointCollectionPoint_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DataPoint_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_ColumnPosition")]
    protected Info _ColumnPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_RowPosition")]
    protected Info _RowPosition;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint_Info_IsFrozen")]
    protected new Info _IsFrozen;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
