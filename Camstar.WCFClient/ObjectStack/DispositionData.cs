// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionData
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
  public class DispositionData : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_EventFailures")]
    protected SubentityRef[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_QuantityConforming")]
    protected Primitive<string> _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_QuantityRemaining")]
    protected Primitive<string> _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_QuantityDispositioned")]
    protected Primitive<string> _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_LotQty")]
    protected Primitive<string> _LotQty;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_LotHoldRecommended")]
    protected Primitive<bool> _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Product")]
    protected Primitive<string> _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DispositionData && this.CompareArrays((Array) this._EventFailures, (Array) ((DispositionData) obj)._EventFailures) && (object.Equals((object) this._ExportImportKey, (object) ((DispositionData) obj)._ExportImportKey) && object.Equals((object) this._EventLot, (object) ((DispositionData) obj)._EventLot)) && (object.Equals((object) this._QuantityConforming, (object) ((DispositionData) obj)._QuantityConforming) && object.Equals((object) this._QuantityRemaining, (object) ((DispositionData) obj)._QuantityRemaining) && (object.Equals((object) this._QuantityDispositioned, (object) ((DispositionData) obj)._QuantityDispositioned) && object.Equals((object) this._QuantityAssigned, (object) ((DispositionData) obj)._QuantityAssigned))) && (object.Equals((object) this._LotQty, (object) ((DispositionData) obj)._LotQty) && object.Equals((object) this._LotHoldRecommended, (object) ((DispositionData) obj)._LotHoldRecommended) && (object.Equals((object) this._Product, (object) ((DispositionData) obj)._Product) && object.Equals((object) this._Lot, (object) ((DispositionData) obj)._Lot)) && (object.Equals((object) this._UOMName, (object) ((DispositionData) obj)._UOMName) && object.Equals((object) this._IsFrozen, (object) ((DispositionData) obj)._IsFrozen))) && base.Equals(obj);
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

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
