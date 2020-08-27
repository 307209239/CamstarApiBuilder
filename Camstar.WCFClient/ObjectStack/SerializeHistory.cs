// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeHistory
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
  public class SerializeHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_HistoryDetails")]
    protected SerializeHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistory_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is SerializeHistory && object.Equals((object) this._UOM2, (object) ((SerializeHistory) obj)._UOM2) && (object.Equals((object) this._UOM, (object) ((SerializeHistory) obj)._UOM) && object.Equals((object) this._Qty2, (object) ((SerializeHistory) obj)._Qty2)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((SerializeHistory) obj)._HistoryDetails) && object.Equals((object) this._ExportImportKey, (object) ((SerializeHistory) obj)._ExportImportKey) && (object.Equals((object) this._UnitCount, (object) ((SerializeHistory) obj)._UnitCount) && object.Equals((object) this._ChildCount, (object) ((SerializeHistory) obj)._ChildCount))) && (object.Equals((object) this._HistoryId, (object) ((SerializeHistory) obj)._HistoryId) && object.Equals((object) this._Qty, (object) ((SerializeHistory) obj)._Qty)) && base.Equals(obj);
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
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

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public SerializeHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SerializeHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
