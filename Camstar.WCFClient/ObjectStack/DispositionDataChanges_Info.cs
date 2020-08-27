// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDataChanges_Info
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
  public class DispositionDataChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_EventFailures")]
    protected Info _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_AvailableFailures")]
    protected EventFailure_Info _AvailableFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_Parent")]
    protected new Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QtySampled")]
    protected Info _QtySampled;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QtyAffected")]
    protected Info _QtyAffected;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_LotQty")]
    protected Info _LotQty;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QuantityConforming")]
    protected Info _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_Quantity")]
    protected Info _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QuantityRemaining")]
    protected Info _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_QuantityDispositioned")]
    protected Info _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_Selected")]
    protected Info _Selected;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_LotHoldRecommended")]
    protected Info _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Info_UOMName")]
    protected Info _UOMName;

    public Info EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventFailures));
      }
    }

    public EventFailure_Info AvailableFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableFailures), (object) value);
      }
      get
      {
        return (EventFailure_Info) this.PropertyGet(nameof (AvailableFailures));
      }
    }

    public Info EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventLot));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public new Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
      }
    }

    public Info QtySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtySampled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtySampled));
      }
    }

    public Info QtyAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAffected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyAffected));
      }
    }

    public Info LotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotQty));
      }
    }

    public Info QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Info Quantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Quantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Quantity));
      }
    }

    public Info QuantityRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityRemaining), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityRemaining));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Info Selected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Selected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Selected));
      }
    }

    public Info LotHoldRecommended
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotHoldRecommended), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotHoldRecommended));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }

    public Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }
  }
}
