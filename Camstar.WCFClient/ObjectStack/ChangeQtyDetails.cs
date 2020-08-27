// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQtyDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (LossDetails))]
  [KnownType(typeof (BonusDetails))]
  [KnownType(typeof (AdjustDetails))]
  [KnownType(typeof (SellDetails))]
  [KnownType(typeof (BuyDetails))]
  [Serializable]
  public class ChangeQtyDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_AdjustThruput")]
    protected Primitive<bool> _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_TypeSortOrder")]
    protected Primitive<int> _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_RecordAllQty")]
    protected Primitive<bool> _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_ChangeQtyType")]
    protected Primitive<int> _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_QtyMultiplier")]
    protected Primitive<int> _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_CountsAgainstProduction")]
    protected Primitive<bool> _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_ReasonCode")]
    protected NamedObjectRef _ReasonCode;

    public override bool Equals(object obj)
    {
      return obj is ChangeQtyDetails && object.Equals((object) this._Qty2, (object) ((ChangeQtyDetails) obj)._Qty2) && (object.Equals((object) this._Comments, (object) ((ChangeQtyDetails) obj)._Comments) && object.Equals((object) this._Container, (object) ((ChangeQtyDetails) obj)._Container)) && (object.Equals((object) this._AdjustThruput, (object) ((ChangeQtyDetails) obj)._AdjustThruput) && object.Equals((object) this._TypeSortOrder, (object) ((ChangeQtyDetails) obj)._TypeSortOrder) && (object.Equals((object) this._RecordAllQty, (object) ((ChangeQtyDetails) obj)._RecordAllQty) && object.Equals((object) this._ChangeQtyType, (object) ((ChangeQtyDetails) obj)._ChangeQtyType))) && (object.Equals((object) this._QtyMultiplier, (object) ((ChangeQtyDetails) obj)._QtyMultiplier) && object.Equals((object) this._CountsAgainstProduction, (object) ((ChangeQtyDetails) obj)._CountsAgainstProduction) && (object.Equals((object) this._Qty, (object) ((ChangeQtyDetails) obj)._Qty) && object.Equals((object) this._ChargeToStep, (object) ((ChangeQtyDetails) obj)._ChargeToStep)) && object.Equals((object) this._ReasonCode, (object) ((ChangeQtyDetails) obj)._ReasonCode)) && base.Equals(obj);
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

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
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

    public Primitive<bool> AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Primitive<int> TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TypeSortOrder));
      }
    }

    public Primitive<bool> RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public Primitive<int> ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public Primitive<int> QtyMultiplier
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyMultiplier), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (QtyMultiplier));
      }
    }

    public Primitive<bool> CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CountsAgainstProduction));
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

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
      }
    }
  }
}
