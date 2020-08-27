// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LossDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyCarrierDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class LossDetails : ChangeQtyDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_RecordAllQty")]
    protected new Primitive<bool> _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_CountsAgainstProduction")]
    protected new Primitive<bool> _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_AdjustThruput")]
    protected new Primitive<bool> _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_ChangeQtyType")]
    protected new Primitive<int> _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_TypeSortOrder")]
    protected new Primitive<int> _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_QtyMultiplier")]
    protected new Primitive<int> _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_ChargeToStep")]
    protected new NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Qty")]
    protected new Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is LossDetails && object.Equals((object) this._ReasonCode, (object) ((LossDetails) obj)._ReasonCode) && (object.Equals((object) this._Qty2, (object) ((LossDetails) obj)._Qty2) && object.Equals((object) this._RecordAllQty, (object) ((LossDetails) obj)._RecordAllQty)) && (object.Equals((object) this._CountsAgainstProduction, (object) ((LossDetails) obj)._CountsAgainstProduction) && object.Equals((object) this._AdjustThruput, (object) ((LossDetails) obj)._AdjustThruput) && (object.Equals((object) this._ChangeQtyType, (object) ((LossDetails) obj)._ChangeQtyType) && object.Equals((object) this._TypeSortOrder, (object) ((LossDetails) obj)._TypeSortOrder))) && (object.Equals((object) this._Container, (object) ((LossDetails) obj)._Container) && object.Equals((object) this._QtyMultiplier, (object) ((LossDetails) obj)._QtyMultiplier) && (object.Equals((object) this._ChargeToStep, (object) ((LossDetails) obj)._ChargeToStep) && object.Equals((object) this._Qty, (object) ((LossDetails) obj)._Qty))) && base.Equals(obj);
    }

    public new NamedObjectRef ReasonCode
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

    public new Primitive<bool> RecordAllQty
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

    public new Primitive<bool> CountsAgainstProduction
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

    public new Primitive<bool> AdjustThruput
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

    public new Primitive<int> ChangeQtyType
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

    public new Primitive<int> TypeSortOrder
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

    public new ContainerRef Container
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

    public new Primitive<int> QtyMultiplier
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

    public new NamedSubentityRef ChargeToStep
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
  }
}
