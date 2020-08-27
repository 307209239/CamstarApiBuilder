// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDetail
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
  public class DispositionDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_QuantityConforming")]
    protected Primitive<string> _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_HistorySummary")]
    protected SubentityRef _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_DispositionData")]
    protected SubentityRef _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_QuantityDispositioned")]
    protected Primitive<string> _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_LotQuantity")]
    protected Primitive<string> _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Product")]
    protected Primitive<string> _Product;

    public override bool Equals(object obj)
    {
      return obj is DispositionDetail && object.Equals((object) this._EventLot, (object) ((DispositionDetail) obj)._EventLot) && (object.Equals((object) this._QuantityConforming, (object) ((DispositionDetail) obj)._QuantityConforming) && object.Equals((object) this._HistorySummary, (object) ((DispositionDetail) obj)._HistorySummary)) && (object.Equals((object) this._DispositionData, (object) ((DispositionDetail) obj)._DispositionData) && object.Equals((object) this._QuantityAssigned, (object) ((DispositionDetail) obj)._QuantityAssigned) && (object.Equals((object) this._QuantityDispositioned, (object) ((DispositionDetail) obj)._QuantityDispositioned) && object.Equals((object) this._LotQuantity, (object) ((DispositionDetail) obj)._LotQuantity))) && (object.Equals((object) this._UOMName, (object) ((DispositionDetail) obj)._UOMName) && object.Equals((object) this._Lot, (object) ((DispositionDetail) obj)._Lot) && object.Equals((object) this._Product, (object) ((DispositionDetail) obj)._Product)) && base.Equals(obj);
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

    public SubentityRef HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public SubentityRef DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DispositionData));
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

    public Primitive<string> LotQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQuantity), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LotQuantity));
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

    public Primitive<string> Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Product));
      }
    }
  }
}
