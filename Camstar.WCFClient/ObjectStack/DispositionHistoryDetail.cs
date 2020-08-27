// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionHistoryDetail
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
  public class DispositionHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_QuantityDispositioned")]
    protected Primitive<string> _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_LotQuantity")]
    protected Primitive<string> _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_QuantityConforming")]
    protected Primitive<string> _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Product")]
    protected Primitive<string> _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Lot")]
    protected Primitive<string> _Lot;

    public override bool Equals(object obj)
    {
      return obj is DispositionHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((DispositionHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._QuantityDispositioned, (object) ((DispositionHistoryDetail) obj)._QuantityDispositioned) && object.Equals((object) this._QuantityAssigned, (object) ((DispositionHistoryDetail) obj)._QuantityAssigned)) && (object.Equals((object) this._LotQuantity, (object) ((DispositionHistoryDetail) obj)._LotQuantity) && object.Equals((object) this._QuantityConforming, (object) ((DispositionHistoryDetail) obj)._QuantityConforming) && (object.Equals((object) this._UOMName, (object) ((DispositionHistoryDetail) obj)._UOMName) && object.Equals((object) this._HistoryId, (object) ((DispositionHistoryDetail) obj)._HistoryId))) && (object.Equals((object) this._Product, (object) ((DispositionHistoryDetail) obj)._Product) && object.Equals((object) this._Lot, (object) ((DispositionHistoryDetail) obj)._Lot)) && base.Equals(obj);
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
  }
}
