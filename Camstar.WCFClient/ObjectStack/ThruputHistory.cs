// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputHistory
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
  public class ThruputHistory : MovementHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_HistoryDetails")]
    protected ThruputHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_ChildCount")]
    protected new Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_UnitCount")]
    protected new Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_ThruputAllQty")]
    protected Primitive<bool> _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Setup")]
    protected new RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_ElapsedTime")]
    protected new Primitive<double> _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Run")]
    protected new Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_CycleTime")]
    protected new Primitive<double> _CycleTime;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Owner")]
    protected new NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is ThruputHistory && object.Equals((object) this._Qty2, (object) ((ThruputHistory) obj)._Qty2) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ThruputHistory) obj)._HistoryDetails) && object.Equals((object) this._UOM2, (object) ((ThruputHistory) obj)._UOM2)) && (object.Equals((object) this._UOM, (object) ((ThruputHistory) obj)._UOM) && object.Equals((object) this._ExportImportKey, (object) ((ThruputHistory) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((ThruputHistory) obj)._HistoryId) && object.Equals((object) this._ChildCount, (object) ((ThruputHistory) obj)._ChildCount))) && (object.Equals((object) this._Container, (object) ((ThruputHistory) obj)._Container) && object.Equals((object) this._UnitCount, (object) ((ThruputHistory) obj)._UnitCount) && (object.Equals((object) this._ThruputAllQty, (object) ((ThruputHistory) obj)._ThruputAllQty) && object.Equals((object) this._Product, (object) ((ThruputHistory) obj)._Product)) && (object.Equals((object) this._Setup, (object) ((ThruputHistory) obj)._Setup) && object.Equals((object) this._Resource, (object) ((ThruputHistory) obj)._Resource) && (object.Equals((object) this._Operation, (object) ((ThruputHistory) obj)._Operation) && object.Equals((object) this._ElapsedTime, (object) ((ThruputHistory) obj)._ElapsedTime)))) && (object.Equals((object) this._Run, (object) ((ThruputHistory) obj)._Run) && object.Equals((object) this._Qty, (object) ((ThruputHistory) obj)._Qty) && (object.Equals((object) this._CycleTime, (object) ((ThruputHistory) obj)._CycleTime) && object.Equals((object) this._Owner, (object) ((ThruputHistory) obj)._Owner))) && base.Equals(obj);
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

    public ThruputHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ThruputHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public Primitive<bool> ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThruputAllQty));
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

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
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
  }
}
