// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LossDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyCarrierDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class LossDetails_Info : ChangeQtyDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_ReasonCode")]
    protected new Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_RecordAllQty")]
    protected new Info _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_CountsAgainstProduction")]
    protected new Info _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_AdjustThruput")]
    protected new Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_ChangeQtyType")]
    protected new Info _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_TypeSortOrder")]
    protected new Info _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_QtyMultiplier")]
    protected new Info _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_ChargeToStep")]
    protected new Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Info_Qty")]
    protected new Info _Qty;

    public new Info ReasonCode
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

    public new Info Qty2
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

    public new Info RecordAllQty
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

    public new Info CountsAgainstProduction
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

    public new Info AdjustThruput
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

    public new Info ChangeQtyType
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

    public new Info TypeSortOrder
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

    public new Info Container
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

    public new Info QtyMultiplier
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

    public new Info ChargeToStep
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

    public new Info Qty
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
  }
}
