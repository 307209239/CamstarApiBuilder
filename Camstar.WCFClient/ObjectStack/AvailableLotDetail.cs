// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AvailableLotDetail
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
  public class AvailableLotDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Quantity")]
    protected Primitive<string> _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Status")]
    protected Enumeration<LotDispositionStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_QuantityRemaining")]
    protected Primitive<string> _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_QuantityReconciled")]
    protected Primitive<string> _QuantityReconciled;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_LotHoldRecommended")]
    protected Primitive<bool> _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_StatusName")]
    protected Primitive<string> _StatusName;

    public override bool Equals(object obj)
    {
      return obj is AvailableLotDetail && object.Equals((object) this._EventLot, (object) ((AvailableLotDetail) obj)._EventLot) && (object.Equals((object) this._Quantity, (object) ((AvailableLotDetail) obj)._Quantity) && object.Equals((object) this._QuantityAssigned, (object) ((AvailableLotDetail) obj)._QuantityAssigned)) && (object.Equals((object) this._Status, (object) ((AvailableLotDetail) obj)._Status) && object.Equals((object) this._QuantityRemaining, (object) ((AvailableLotDetail) obj)._QuantityRemaining) && (object.Equals((object) this._QuantityReconciled, (object) ((AvailableLotDetail) obj)._QuantityReconciled) && object.Equals((object) this._LotHoldRecommended, (object) ((AvailableLotDetail) obj)._LotHoldRecommended))) && (object.Equals((object) this._ProductName, (object) ((AvailableLotDetail) obj)._ProductName) && object.Equals((object) this._UOMName, (object) ((AvailableLotDetail) obj)._UOMName) && (object.Equals((object) this._Lot, (object) ((AvailableLotDetail) obj)._Lot) && object.Equals((object) this._StatusName, (object) ((AvailableLotDetail) obj)._StatusName))) && base.Equals(obj);
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

    public Enumeration<LotDispositionStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<LotDispositionStatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public Primitive<string> QuantityReconciled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityReconciled), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityReconciled));
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

    public Primitive<string> StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusName));
      }
    }
  }
}
