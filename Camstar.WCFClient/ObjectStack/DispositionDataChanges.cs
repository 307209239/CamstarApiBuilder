// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDataChanges
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
  public class DispositionDataChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_EventFailures")]
    protected SubentityRef[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_AvailableFailures")]
    protected EventFailure[] _AvailableFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Parent")]
    protected NamedSubentityRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QtySampled")]
    protected Primitive<string> _QtySampled;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QtyAffected")]
    protected Primitive<string> _QtyAffected;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_LotQty")]
    protected Primitive<string> _LotQty;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QuantityConforming")]
    protected Primitive<string> _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Quantity")]
    protected Primitive<string> _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QuantityRemaining")]
    protected Primitive<string> _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_QuantityDispositioned")]
    protected Primitive<string> _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Selected")]
    protected Primitive<bool> _Selected;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_LotHoldRecommended")]
    protected Primitive<bool> _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_UOMName")]
    protected Primitive<string> _UOMName;

    public override bool Equals(object obj)
    {
      return obj is DispositionDataChanges && this.CompareArrays((Array) this._EventFailures, (Array) ((DispositionDataChanges) obj)._EventFailures) && (this.CompareArrays((Array) this._AvailableFailures, (Array) ((DispositionDataChanges) obj)._AvailableFailures) && object.Equals((object) this._EventLot, (object) ((DispositionDataChanges) obj)._EventLot)) && (object.Equals((object) this._ListItemToChange, (object) ((DispositionDataChanges) obj)._ListItemToChange) && object.Equals((object) this._QuantityAssigned, (object) ((DispositionDataChanges) obj)._QuantityAssigned) && (object.Equals((object) this._Parent, (object) ((DispositionDataChanges) obj)._Parent) && object.Equals((object) this._QtySampled, (object) ((DispositionDataChanges) obj)._QtySampled))) && (object.Equals((object) this._QtyAffected, (object) ((DispositionDataChanges) obj)._QtyAffected) && object.Equals((object) this._LotQty, (object) ((DispositionDataChanges) obj)._LotQty) && (object.Equals((object) this._QuantityConforming, (object) ((DispositionDataChanges) obj)._QuantityConforming) && object.Equals((object) this._Quantity, (object) ((DispositionDataChanges) obj)._Quantity)) && (object.Equals((object) this._QuantityRemaining, (object) ((DispositionDataChanges) obj)._QuantityRemaining) && object.Equals((object) this._ObjectToChange, (object) ((DispositionDataChanges) obj)._ObjectToChange) && (object.Equals((object) this._QuantityDispositioned, (object) ((DispositionDataChanges) obj)._QuantityDispositioned) && object.Equals((object) this._Selected, (object) ((DispositionDataChanges) obj)._Selected)))) && (object.Equals((object) this._LotHoldRecommended, (object) ((DispositionDataChanges) obj)._LotHoldRecommended) && object.Equals((object) this._ProductName, (object) ((DispositionDataChanges) obj)._ProductName) && (object.Equals((object) this._Lot, (object) ((DispositionDataChanges) obj)._Lot) && object.Equals((object) this._UOMName, (object) ((DispositionDataChanges) obj)._UOMName))) && base.Equals(obj);
    }

    public SubentityRef[] EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventFailures));
      }
    }

    public EventFailure[] AvailableFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableFailures), (object) value);
      }
      get
      {
        return (EventFailure[]) this.PropertyGet(nameof (AvailableFailures));
      }
    }

    public SubentityRef EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventLot));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<string> QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public NamedSubentityRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Parent));
      }
    }

    public Primitive<string> QtySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtySampled), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QtySampled));
      }
    }

    public Primitive<string> QtyAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAffected), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QtyAffected));
      }
    }

    public Primitive<string> LotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQty), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LotQty));
      }
    }

    public Primitive<string> QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Primitive<string> Quantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Quantity), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Quantity));
      }
    }

    public Primitive<string> QuantityRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityRemaining), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityRemaining));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Primitive<bool> Selected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Selected), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Selected));
      }
    }

    public Primitive<bool> LotHoldRecommended
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotHoldRecommended), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LotHoldRecommended));
      }
    }

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }
  }
}
