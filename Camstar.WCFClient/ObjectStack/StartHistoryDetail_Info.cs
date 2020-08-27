// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartHistoryDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MaterialContainerHistoryDetail_Info))]
  [KnownType(typeof (GroupHistoryDetail_Info))]
  [KnownType(typeof (UnitHistoryDetail_Info))]
  [KnownType(typeof (BatchStartHistoryDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StartHistoryDetail_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedQty2")]
    protected Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedQtyUOM")]
    protected Info _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_StartReason")]
    protected Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedQtyUOM2")]
    protected Info _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Attributes")]
    protected Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_ExpirationDateGMT")]
    protected Info _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedStartDate")]
    protected Info _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedStartDateGMT")]
    protected Info _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_InQualityControl")]
    protected Info _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_RequestDate")]
    protected Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_SamplingRequired")]
    protected Info _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_SalesOrder")]
    protected Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedProduct")]
    protected Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_PlannedQty")]
    protected Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_MfgOrder")]
    protected Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Info_ContainerComments")]
    protected Info _ContainerComments;

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

    public Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public Info UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitCount));
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

    public Info ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Info PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Info PlannedStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedStartDateGMT));
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

    public Info InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InQualityControl));
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

    public Info SamplingRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingRequired));
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

    public Info ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildCount));
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

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
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

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
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

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
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
  }
}
