// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgLotDetail
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
  public class MfgLotDetail : MfgDataDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Status")]
    protected Primitive<int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Product")]
    protected Primitive<string> _Product;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Factory")]
    protected Primitive<string> _Factory;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_UOM")]
    protected Primitive<string> _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Operation")]
    protected Primitive<string> _Operation;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_WorkCenter")]
    protected Primitive<string> _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_StatusName")]
    protected Primitive<string> _StatusName;

    public override bool Equals(object obj)
    {
      return obj is MfgLotDetail && object.Equals((object) this._OriginalStartDate, (object) ((MfgLotDetail) obj)._OriginalStartDate) && (object.Equals((object) this._Status, (object) ((MfgLotDetail) obj)._Status) && object.Equals((object) this._Product, (object) ((MfgLotDetail) obj)._Product)) && (object.Equals((object) this._Factory, (object) ((MfgLotDetail) obj)._Factory) && object.Equals((object) this._Qty, (object) ((MfgLotDetail) obj)._Qty) && (object.Equals((object) this._UOM, (object) ((MfgLotDetail) obj)._UOM) && object.Equals((object) this._Lot, (object) ((MfgLotDetail) obj)._Lot))) && (object.Equals((object) this._Operation, (object) ((MfgLotDetail) obj)._Operation) && object.Equals((object) this._WorkCenter, (object) ((MfgLotDetail) obj)._WorkCenter) && (object.Equals((object) this._ProductRev, (object) ((MfgLotDetail) obj)._ProductRev) && object.Equals((object) this._StatusName, (object) ((MfgLotDetail) obj)._StatusName))) && base.Equals(obj);
    }

    public Primitive<DateTime> OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Primitive<int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Status));
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

    public Primitive<string> Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Factory));
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

    public Primitive<string> UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOM));
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

    public Primitive<string> Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Operation));
      }
    }

    public Primitive<string> WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
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
