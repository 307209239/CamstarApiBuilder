// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovementHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MoveHistory))]
  [KnownType(typeof (ThruputHistory))]
  [KnownType(typeof (MoveInHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MovementHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_CycleTime")]
    protected Primitive<double> _CycleTime;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_ElapsedTime")]
    protected Primitive<double> _ElapsedTime;

    public override bool Equals(object obj)
    {
      return obj is MovementHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((MovementHistory) obj)._HistoryDetails) && (object.Equals((object) this._Qty2, (object) ((MovementHistory) obj)._Qty2) && object.Equals((object) this._UOM2, (object) ((MovementHistory) obj)._UOM2)) && (object.Equals((object) this._UOM, (object) ((MovementHistory) obj)._UOM) && object.Equals((object) this._ExportImportKey, (object) ((MovementHistory) obj)._ExportImportKey) && (object.Equals((object) this._UnitCount, (object) ((MovementHistory) obj)._UnitCount) && object.Equals((object) this._ChildCount, (object) ((MovementHistory) obj)._ChildCount))) && (object.Equals((object) this._HistoryId, (object) ((MovementHistory) obj)._HistoryId) && object.Equals((object) this._Owner, (object) ((MovementHistory) obj)._Owner) && (object.Equals((object) this._Run, (object) ((MovementHistory) obj)._Run) && object.Equals((object) this._Setup, (object) ((MovementHistory) obj)._Setup)) && (object.Equals((object) this._Product, (object) ((MovementHistory) obj)._Product) && object.Equals((object) this._Qty, (object) ((MovementHistory) obj)._Qty) && (object.Equals((object) this._CycleTime, (object) ((MovementHistory) obj)._CycleTime) && object.Equals((object) this._ElapsedTime, (object) ((MovementHistory) obj)._ElapsedTime)))) && base.Equals(obj);
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

    public NamedObjectRef Owner
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

    public Primitive<string> Run
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

    public RevisionedObjectRef Setup
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

    public RevisionedObjectRef Product
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

    public Primitive<double> CycleTime
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

    public Primitive<double> ElapsedTime
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
  }
}
