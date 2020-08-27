// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveInHistory
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
  public class MoveInHistory : MovementHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_UnitCount")]
    protected new Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_ChildCount")]
    protected new Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Run")]
    protected new Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_CycleTime")]
    protected new Primitive<double> _CycleTime;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_ElapsedTime")]
    protected new Primitive<double> _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Setup")]
    protected new RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveInHistory_Product")]
    protected new RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is MoveInHistory && object.Equals((object) this._UOM2, (object) ((MoveInHistory) obj)._UOM2) && (object.Equals((object) this._ExportImportKey, (object) ((MoveInHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((MoveInHistory) obj)._HistoryDetails)) && (object.Equals((object) this._UOM, (object) ((MoveInHistory) obj)._UOM) && object.Equals((object) this._Qty2, (object) ((MoveInHistory) obj)._Qty2) && (object.Equals((object) this._UnitCount, (object) ((MoveInHistory) obj)._UnitCount) && object.Equals((object) this._ChildCount, (object) ((MoveInHistory) obj)._ChildCount))) && (object.Equals((object) this._HistoryId, (object) ((MoveInHistory) obj)._HistoryId) && object.Equals((object) this._Run, (object) ((MoveInHistory) obj)._Run) && (object.Equals((object) this._CycleTime, (object) ((MoveInHistory) obj)._CycleTime) && object.Equals((object) this._ElapsedTime, (object) ((MoveInHistory) obj)._ElapsedTime)) && (object.Equals((object) this._Location, (object) ((MoveInHistory) obj)._Location) && object.Equals((object) this._Setup, (object) ((MoveInHistory) obj)._Setup) && (object.Equals((object) this._Owner, (object) ((MoveInHistory) obj)._Owner) && object.Equals((object) this._Qty, (object) ((MoveInHistory) obj)._Qty)))) && object.Equals((object) this._Product, (object) ((MoveInHistory) obj)._Product) && base.Equals(obj);
    }

    public new NamedObjectRef UOM2
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new NamedObjectRef UOM
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

    public new Primitive<double> Qty2
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

    public new Primitive<int> UnitCount
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

    public new Primitive<int> ChildCount
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

    public new Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public new Primitive<double> CycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (CycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CycleTime));
      }
    }

    public new Primitive<double> ElapsedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElapsedTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ElapsedTime));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public new RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }

    public new NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public new Primitive<double> Qty
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

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
