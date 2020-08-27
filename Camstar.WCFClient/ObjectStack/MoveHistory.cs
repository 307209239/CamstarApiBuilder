// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ShipHistory))]
  [KnownType(typeof (TransferHistory))]
  [KnownType(typeof (ReworkHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MoveHistory : MovementHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ChildCount")]
    protected new Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Close")]
    protected Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ToStepUsage")]
    protected Primitive<int> _ToStepUsage;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_UnitCount")]
    protected new Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_MoveAllQty")]
    protected Primitive<bool> _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ElapsedTime")]
    protected new Primitive<double> _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Run")]
    protected new Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_ToResource")]
    protected NamedObjectRef _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Setup")]
    protected new RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_CycleTime")]
    protected new Primitive<double> _CycleTime;

    public override bool Equals(object obj)
    {
      return obj is MoveHistory && object.Equals((object) this._ExportImportKey, (object) ((MoveHistory) obj)._ExportImportKey) && (object.Equals((object) this._Step, (object) ((MoveHistory) obj)._Step) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((MoveHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Qty2, (object) ((MoveHistory) obj)._Qty2) && object.Equals((object) this._ToStep, (object) ((MoveHistory) obj)._ToStep) && (object.Equals((object) this._UOM2, (object) ((MoveHistory) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((MoveHistory) obj)._UOM))) && (object.Equals((object) this._ChildCount, (object) ((MoveHistory) obj)._ChildCount) && object.Equals((object) this._HistoryId, (object) ((MoveHistory) obj)._HistoryId) && (object.Equals((object) this._Close, (object) ((MoveHistory) obj)._Close) && object.Equals((object) this._ToStepUsage, (object) ((MoveHistory) obj)._ToStepUsage)) && (object.Equals((object) this._UnitCount, (object) ((MoveHistory) obj)._UnitCount) && object.Equals((object) this._MoveAllQty, (object) ((MoveHistory) obj)._MoveAllQty) && (object.Equals((object) this._ElapsedTime, (object) ((MoveHistory) obj)._ElapsedTime) && object.Equals((object) this._ToLocation, (object) ((MoveHistory) obj)._ToLocation)))) && (object.Equals((object) this._Owner, (object) ((MoveHistory) obj)._Owner) && object.Equals((object) this._Product, (object) ((MoveHistory) obj)._Product) && (object.Equals((object) this._Run, (object) ((MoveHistory) obj)._Run) && object.Equals((object) this._ToResource, (object) ((MoveHistory) obj)._ToResource)) && (object.Equals((object) this._Qty, (object) ((MoveHistory) obj)._Qty) && object.Equals((object) this._Setup, (object) ((MoveHistory) obj)._Setup) && (object.Equals((object) this._Location, (object) ((MoveHistory) obj)._Location) && object.Equals((object) this._Path, (object) ((MoveHistory) obj)._Path))) && object.Equals((object) this._CycleTime, (object) ((MoveHistory) obj)._CycleTime)) && base.Equals(obj);
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

    public NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
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

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
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

    public Primitive<bool> Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Close));
      }
    }

    public Primitive<int> ToStepUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepUsage), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ToStepUsage));
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

    public Primitive<bool> MoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MoveAllQty));
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

    public NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
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

    public NamedObjectRef ToResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToResource));
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

    public NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
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
  }
}
