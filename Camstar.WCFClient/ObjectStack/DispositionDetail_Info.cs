// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDetail_Info
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
  public class DispositionDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_QuantityConforming")]
    protected Info _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_HistorySummary")]
    protected Info _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_DispositionData")]
    protected Info _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_QuantityDispositioned")]
    protected Info _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_LotQuantity")]
    protected Info _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Info_Product")]
    protected Info _Product;

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

    public Info HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Info DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispositionData));
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

    public Info LotQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQuantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotQuantity));
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

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
