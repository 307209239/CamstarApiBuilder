// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionData_Info
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
  public class DispositionData_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_EventFailures")]
    protected Info _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_QuantityConforming")]
    protected Info _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_QuantityRemaining")]
    protected Info _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_QuantityDispositioned")]
    protected Info _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_LotQty")]
    protected Info _LotQty;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_LotHoldRecommended")]
    protected Info _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
