// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQtyDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SellDetails_Info))]
  [KnownType(typeof (BonusDetails_Info))]
  [KnownType(typeof (BuyDetails_Info))]
  [KnownType(typeof (LossDetails_Info))]
  [KnownType(typeof (AdjustDetails_Info))]
  [Serializable]
  public class ChangeQtyDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_AdjustThruput")]
    protected Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_TypeSortOrder")]
    protected Info _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_RecordAllQty")]
    protected Info _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_ChangeQtyType")]
    protected Info _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_QtyMultiplier")]
    protected Info _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_CountsAgainstProduction")]
    protected Info _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Info_ReasonCode")]
    protected Info _ReasonCode;

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Info TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TypeSortOrder));
      }
    }

    public Info RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public Info ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public Info QtyMultiplier
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyMultiplier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyMultiplier));
      }
    }

    public Info CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CountsAgainstProduction));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
      }
    }
  }
}
