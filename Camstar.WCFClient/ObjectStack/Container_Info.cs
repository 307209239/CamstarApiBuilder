// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Container_Info
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
  public class Container_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ProjectedQty2")]
    protected Info _ProjectedQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ThruputAdjustmentQty2")]
    protected Info _ThruputAdjustmentQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalQty2")]
    protected Info _OriginalQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_BOM")]
    protected Info _BOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalUOM2")]
    protected Info _OriginalUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartQty2")]
    protected Info _FactoryStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedQty2")]
    protected Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OpenNonconformanceReports")]
    protected Info _OpenNonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OpenEvents")]
    protected Info _OpenEvents;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_GateStatus")]
    protected GateStatus_Info _GateStatus;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Detail")]
    protected ContainerDetail_Info _Detail;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_SpecStatus")]
    protected SpecStatus_Info _SpecStatus;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalUOM")]
    protected Info _OriginalUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartUOM2")]
    protected Info _FactoryStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedQtyUOM2")]
    protected Info _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentThruputQty2")]
    protected Info _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_NonconformanceReports")]
    protected Info _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedQtyUOM")]
    protected Info _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_StartReason")]
    protected Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ContainerMaterialList")]
    protected ContainerMaterialListItem_Info _ContainerMaterialList;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartUOM")]
    protected Info _FactoryStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_RelativePriority")]
    protected Info _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_DataPointCollections")]
    protected Info _DataPointCollections;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ContainerSampleData")]
    protected ContainerSampleData_Info _ContainerSampleData;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Attributes")]
    protected UserAttribute_Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_AttachDocumentDetails")]
    protected AttachDocumentDetails_Info _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalStartDate")]
    protected Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_InQualityControl")]
    protected Info _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastMoveDateGMT")]
    protected Info _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartDate")]
    protected Info _FactoryStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_SamplingPassed")]
    protected Info _SamplingPassed;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedStartDate")]
    protected Info _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentHoldCount")]
    protected Info _CurrentHoldCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastCompletionDateGMT")]
    protected Info _LastCompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Parent")]
    protected Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ThruputAdjustmentChildCount")]
    protected Info _ThruputAdjustmentChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartDateGMT")]
    protected Info _FactoryStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastActivityDate")]
    protected Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ThisContainerLost")]
    protected Info _ThisContainerLost;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_SamplingRequired")]
    protected Info _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentThruputUnitCount")]
    protected Info _CurrentThruputUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastCompletionDate")]
    protected Info _LastCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_IssuedToContainer")]
    protected Info _IssuedToContainer;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OnHoldDate")]
    protected Info _OnHoldDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ThruputAdjustmentUnitCount")]
    protected Info _ThruputAdjustmentUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ProjectedDateGMT")]
    protected Info _ProjectedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_RollupUnitCount")]
    protected Info _RollupUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentThruputChildCount")]
    protected Info _CurrentThruputChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalStartDateGMT")]
    protected Info _OriginalStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ExpirationDateGMT")]
    protected Info _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_RequestDate")]
    protected Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastActivityDateGMT")]
    protected Info _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ChildContainers")]
    protected Container_Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ProjectedDate")]
    protected Info _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedStartDateGMT")]
    protected Info _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_IsNDO")]
    protected Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_RequestDateGMT")]
    protected Info _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentStepPass")]
    protected Info _CurrentStepPass;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgr_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_SalesOrder")]
    protected Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalQty")]
    protected Info _OriginalQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Level")]
    protected Info _Level;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ThruputAdjustmentQty")]
    protected Info _ThruputAdjustmentQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_OriginalFactory")]
    protected Info _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_FactoryStartQty")]
    protected Info _FactoryStartQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ProjectedQty")]
    protected Info _ProjectedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedQty")]
    protected Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_MfgOrder")]
    protected Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_CurrentThruputQty")]
    protected Info _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_ContainerComments")]
    protected Info _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_PlannedProduct")]
    protected Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "Container_Info_Workstation")]
    protected Info _Workstation;

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

    public Info ProjectedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProjectedQty2));
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

    public Info ThruputAdjustmentQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAdjustmentQty2));
      }
    }

    public Info OriginalQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalQty2));
      }
    }

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
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

    public Info BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOM));
      }
    }

    public Info OriginalUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalUOM2));
      }
    }

    public Info FactoryStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartQty2));
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

    public Info OpenNonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonconformanceReports), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OpenNonconformanceReports));
      }
    }

    public Info OpenEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenEvents), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OpenEvents));
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

    public GateStatus_Info GateStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateStatus), (object) value);
      }
      get
      {
        return (GateStatus_Info) this.PropertyGet(nameof (GateStatus));
      }
    }

    public ContainerDetail_Info Detail
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detail), (object) value);
      }
      get
      {
        return (ContainerDetail_Info) this.PropertyGet(nameof (Detail));
      }
    }

    public SpecStatus_Info SpecStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStatus), (object) value);
      }
      get
      {
        return (SpecStatus_Info) this.PropertyGet(nameof (SpecStatus));
      }
    }

    public Info OriginalUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalUOM));
      }
    }

    public Info FactoryStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartUOM2));
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

    public Info CurrentThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentThruputQty2));
      }
    }

    public Info NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReports));
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

    public ContainerMaterialListItem_Info ContainerMaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerMaterialList), (object) value);
      }
      get
      {
        return (ContainerMaterialListItem_Info) this.PropertyGet(nameof (ContainerMaterialList));
      }
    }

    public Info FactoryStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartUOM));
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

    public Info DataPointCollections
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollections), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointCollections));
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

    public ContainerSampleData_Info ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (ContainerSampleData_Info) this.PropertyGet(nameof (ContainerSampleData));
      }
    }

    public UserAttribute_Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute_Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public AttachDocumentDetails_Info AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Info) this.PropertyGet(nameof (AttachDocumentDetails));
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

    public Info OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDate));
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

    public Info LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Info FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Info SamplingPassed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPassed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPassed));
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

    public Info CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }

    public Info LastCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletionDateGMT));
      }
    }

    public Info Parent
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

    public Info ThruputAdjustmentChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAdjustmentChildCount));
      }
    }

    public Info FactoryStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartDateGMT));
      }
    }

    public Info LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Info ThisContainerLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerLost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThisContainerLost));
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

    public Info CurrentThruputUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputUnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentThruputUnitCount));
      }
    }

    public Info LastCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletionDate));
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

    public Info IssuedToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedToContainer));
      }
    }

    public Info OnHoldDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHoldDate));
      }
    }

    public Info ThruputAdjustmentUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentUnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAdjustmentUnitCount));
      }
    }

    public Info ProjectedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProjectedDateGMT));
      }
    }

    public Info RollupUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupUnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RollupUnitCount));
      }
    }

    public Info CurrentThruputChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentThruputChildCount));
      }
    }

    public Info OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDateGMT));
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

    public Info LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Container_Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Container_Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info ProjectedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProjectedDate));
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

    public Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Info IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNDO));
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

    public Info IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Info CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStepPass));
      }
    }

    public Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
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

    public WIPMsgDefMgr_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
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

    public Info OriginalQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalQty));
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

    public Info ThruputAdjustmentQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAdjustmentQty));
      }
    }

    public Info OriginalFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalFactory));
      }
    }

    public Info FactoryStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartQty));
      }
    }

    public Info ProjectedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProjectedQty));
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

    public Info CurrentThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentThruputQty));
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
  }
}
