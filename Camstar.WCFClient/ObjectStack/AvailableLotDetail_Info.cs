// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AvailableLotDetail_Info
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
  public class AvailableLotDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_Quantity")]
    protected Info _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_QuantityRemaining")]
    protected Info _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_QuantityReconciled")]
    protected Info _QuantityReconciled;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_LotHoldRecommended")]
    protected Info _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Info_StatusName")]
    protected Info _StatusName;

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

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
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

    public Info QuantityReconciled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityReconciled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityReconciled));
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

    public Info StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusName));
      }
    }
  }
}
