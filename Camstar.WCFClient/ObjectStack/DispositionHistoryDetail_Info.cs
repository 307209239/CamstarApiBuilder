// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionHistoryDetail_Info
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
  public class DispositionHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_QuantityDispositioned")]
    protected Info _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_LotQuantity")]
    protected Info _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_QuantityConforming")]
    protected Info _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Info_Lot")]
    protected Info _Lot;

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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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
  }
}
