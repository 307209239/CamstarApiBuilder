// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintHistDetail_Info
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
  public class ContainerMaintHistDetail_Info : ChgContainerAttrHistDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_RelativePriority")]
    protected Info _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_PlannedQtyUOM")]
    protected Info _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_PlannedQtyUOM2")]
    protected Info _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_StartReason")]
    protected Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_PlannedQty2")]
    protected Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_IsPreHistory")]
    protected new Info _IsPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_RequestDate")]
    protected Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_RequestDateGMT")]
    protected Info _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_SalesOrder")]
    protected Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_PlannedQty")]
    protected Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_ContainerComments")]
    protected Info _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_PlannedProduct")]
    protected Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_MfgOrder")]
    protected Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Level")]
    protected Info _Level;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Info_Name")]
    protected Info _Name;

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

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info RelativePriority
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelativePriority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelativePriority));
      }
    }

    public Info Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Customer));
      }
    }

    public Info PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public Info PlannedQtyUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQtyUOM2));
      }
    }

    public Info StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReason));
      }
    }

    public Info PlannedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty2));
      }
    }

    public Info VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItem));
      }
    }

    public Info BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public new Info IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPreHistory));
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

    public Info RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequestDate));
      }
    }

    public Info DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public Info RequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequestDateGMT));
      }
    }

    public Info ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Info SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SalesOrder));
      }
    }

    public Info PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info ContainerComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerComments));
      }
    }

    public Info Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Priority));
      }
    }

    public Info PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Info Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Level));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
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

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
