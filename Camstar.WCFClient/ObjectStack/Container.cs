// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Container
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
  public class Container : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Container_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "Container_ProjectedQty2")]
    protected Primitive<double> _ProjectedQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "Container_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Status")]
    protected Enumeration<ContainerStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "Container_ThruputAdjustmentQty2")]
    protected Primitive<double> _ThruputAdjustmentQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalQty2")]
    protected Primitive<double> _OriginalQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "Container_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_BOM")]
    protected RevisionedObjectRef _BOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalUOM2")]
    protected NamedObjectRef _OriginalUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartQty2")]
    protected Primitive<double> _FactoryStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_OpenNonconformanceReports")]
    protected NamedObjectRef[] _OpenNonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "Container_OpenEvents")]
    protected NamedObjectRef[] _OpenEvents;
    [DataMember(EmitDefaultValue = false, Name = "Container_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "Container_GateStatus")]
    protected Camstar.WCF.ObjectStack.GateStatus[] _GateStatus;
    [DataMember(EmitDefaultValue = false, Name = "Container_Detail")]
    protected ContainerDetail _Detail;
    [DataMember(EmitDefaultValue = false, Name = "Container_SpecStatus")]
    protected SpecStatus _SpecStatus;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalUOM")]
    protected NamedObjectRef _OriginalUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartUOM2")]
    protected NamedObjectRef _FactoryStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedQtyUOM2")]
    protected NamedObjectRef _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentThruputQty2")]
    protected Primitive<double> _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_NonconformanceReports")]
    protected NamedObjectRef[] _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedQtyUOM")]
    protected NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "Container_ContainerMaterialList")]
    protected ContainerMaterialListItem[] _ContainerMaterialList;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartUOM")]
    protected NamedObjectRef _FactoryStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_RelativePriority")]
    protected Primitive<int> _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "Container_DataPointCollections")]
    protected NamedSubentityRef[] _DataPointCollections;
    [DataMember(EmitDefaultValue = false, Name = "Container_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "Container_ContainerSampleData")]
    protected Camstar.WCF.ObjectStack.ContainerSampleData[] _ContainerSampleData;
    [DataMember(EmitDefaultValue = false, Name = "Container_Attributes")]
    protected UserAttribute[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "Container_AttachDocumentDetails")]
    protected Camstar.WCF.ObjectStack.AttachDocumentDetails[] _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "Container_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_InQualityControl")]
    protected Primitive<int> _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastMoveDateGMT")]
    protected Primitive<DateTime> _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartDate")]
    protected Primitive<DateTime> _FactoryStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_SamplingPassed")]
    protected Primitive<bool> _SamplingPassed;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedStartDate")]
    protected Primitive<DateTime> _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentHoldCount")]
    protected Primitive<int> _CurrentHoldCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastCompletionDateGMT")]
    protected Primitive<DateTime> _LastCompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Parent")]
    protected ContainerRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "Container_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_ThruputAdjustmentChildCount")]
    protected Primitive<int> _ThruputAdjustmentChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartDateGMT")]
    protected Primitive<DateTime> _FactoryStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastActivityDate")]
    protected Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_ThisContainerLost")]
    protected Primitive<bool> _ThisContainerLost;
    [DataMember(EmitDefaultValue = false, Name = "Container_SamplingRequired")]
    protected Primitive<bool> _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "Container_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentThruputUnitCount")]
    protected Primitive<int> _CurrentThruputUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastCompletionDate")]
    protected Primitive<DateTime> _LastCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_IssuedToContainer")]
    protected ContainerRef _IssuedToContainer;
    [DataMember(EmitDefaultValue = false, Name = "Container_OnHoldDate")]
    protected Primitive<DateTime> _OnHoldDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_ThruputAdjustmentUnitCount")]
    protected Primitive<int> _ThruputAdjustmentUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_ProjectedDateGMT")]
    protected Primitive<DateTime> _ProjectedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_RollupUnitCount")]
    protected Primitive<int> _RollupUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentThruputChildCount")]
    protected Primitive<int> _CurrentThruputChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalStartDateGMT")]
    protected Primitive<DateTime> _OriginalStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_ExpirationDateGMT")]
    protected Primitive<DateTime> _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastActivityDateGMT")]
    protected Primitive<DateTime> _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_ChildContainers")]
    protected Container[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Container_ProjectedDate")]
    protected Primitive<DateTime> _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedStartDateGMT")]
    protected Primitive<DateTime> _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "Container_IsNDO")]
    protected Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "Container_RequestDateGMT")]
    protected Primitive<DateTime> _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentStepPass")]
    protected Primitive<int> _CurrentStepPass;
    [DataMember(EmitDefaultValue = false, Name = "Container_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_WIPMsgDefMgr")]
    protected WIPMsgDefMgr _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Container_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalQty")]
    protected Primitive<double> _OriginalQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "Container_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Container_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Level")]
    protected NamedObjectRef _Level;
    [DataMember(EmitDefaultValue = false, Name = "Container_ThruputAdjustmentQty")]
    protected Primitive<double> _ThruputAdjustmentQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_OriginalFactory")]
    protected NamedObjectRef _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "Container_FactoryStartQty")]
    protected Primitive<double> _FactoryStartQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_ProjectedQty")]
    protected Primitive<double> _ProjectedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedQty")]
    protected Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_CurrentThruputQty")]
    protected Primitive<double> _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_ContainerComments")]
    protected Primitive<string> _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "Container_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "Container_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "Container_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "Container_Workstation")]
    protected NamedObjectRef _Workstation;

    public override bool Equals(object obj)
    {
      return obj is Container && object.Equals((object) this._BillOfProcess, (object) ((Container) obj)._BillOfProcess) && (object.Equals((object) this._ProjectedQty2, (object) ((Container) obj)._ProjectedQty2) && object.Equals((object) this._Customer, (object) ((Container) obj)._Customer)) && (object.Equals((object) this._Qty2, (object) ((Container) obj)._Qty2) && object.Equals((object) this._Status, (object) ((Container) obj)._Status) && (object.Equals((object) this._ThruputAdjustmentQty2, (object) ((Container) obj)._ThruputAdjustmentQty2) && object.Equals((object) this._OriginalQty2, (object) ((Container) obj)._OriginalQty2))) && (object.Equals((object) this._HoldReason, (object) ((Container) obj)._HoldReason) && object.Equals((object) this._UOM, (object) ((Container) obj)._UOM) && (object.Equals((object) this._BOM, (object) ((Container) obj)._BOM) && object.Equals((object) this._OriginalUOM2, (object) ((Container) obj)._OriginalUOM2)) && (object.Equals((object) this._FactoryStartQty2, (object) ((Container) obj)._FactoryStartQty2) && object.Equals((object) this._PlannedQty2, (object) ((Container) obj)._PlannedQty2) && (this.CompareArrays((Array) this._OpenNonconformanceReports, (Array) ((Container) obj)._OpenNonconformanceReports) && this.CompareArrays((Array) this._OpenEvents, (Array) ((Container) obj)._OpenEvents)))) && (object.Equals((object) this._VendorItem, (object) ((Container) obj)._VendorItem) && this.CompareArrays((Array) this._GateStatus, (Array) ((Container) obj)._GateStatus) && (object.Equals((object) this._Detail, (object) ((Container) obj)._Detail) && object.Equals((object) this._SpecStatus, (object) ((Container) obj)._SpecStatus)) && (object.Equals((object) this._OriginalUOM, (object) ((Container) obj)._OriginalUOM) && object.Equals((object) this._FactoryStartUOM2, (object) ((Container) obj)._FactoryStartUOM2) && (object.Equals((object) this._PlannedQtyUOM2, (object) ((Container) obj)._PlannedQtyUOM2) && object.Equals((object) this._CurrentThruputQty2, (object) ((Container) obj)._CurrentThruputQty2))) && (this.CompareArrays((Array) this._NonconformanceReports, (Array) ((Container) obj)._NonconformanceReports) && object.Equals((object) this._PlannedQtyUOM, (object) ((Container) obj)._PlannedQtyUOM) && (object.Equals((object) this._StartReason, (object) ((Container) obj)._StartReason) && this.CompareArrays((Array) this._ContainerMaterialList, (Array) ((Container) obj)._ContainerMaterialList)) && (object.Equals((object) this._FactoryStartUOM, (object) ((Container) obj)._FactoryStartUOM) && object.Equals((object) this._UOM2, (object) ((Container) obj)._UOM2) && (object.Equals((object) this._RelativePriority, (object) ((Container) obj)._RelativePriority) && this.CompareArrays((Array) this._DataPointCollections, (Array) ((Container) obj)._DataPointCollections))))) && (object.Equals((object) this._Carrier, (object) ((Container) obj)._Carrier) && this.CompareArrays((Array) this._ContainerSampleData, (Array) ((Container) obj)._ContainerSampleData) && (this.CompareArrays((Array) this._Attributes, (Array) ((Container) obj)._Attributes) && this.CompareArrays((Array) this._AttachDocumentDetails, (Array) ((Container) obj)._AttachDocumentDetails)) && (object.Equals((object) this._SamplingLot, (object) ((Container) obj)._SamplingLot) && object.Equals((object) this._OriginalStartDate, (object) ((Container) obj)._OriginalStartDate) && (object.Equals((object) this._InQualityControl, (object) ((Container) obj)._InQualityControl) && object.Equals((object) this._LastMoveDateGMT, (object) ((Container) obj)._LastMoveDateGMT))) && (object.Equals((object) this._FactoryStartDate, (object) ((Container) obj)._FactoryStartDate) && object.Equals((object) this._SamplingPassed, (object) ((Container) obj)._SamplingPassed) && (object.Equals((object) this._PlannedStartDate, (object) ((Container) obj)._PlannedStartDate) && object.Equals((object) this._CurrentHoldCount, (object) ((Container) obj)._CurrentHoldCount)) && (object.Equals((object) this._LastCompletionDateGMT, (object) ((Container) obj)._LastCompletionDateGMT) && object.Equals((object) this._Parent, (object) ((Container) obj)._Parent) && (object.Equals((object) this._UnitCount, (object) ((Container) obj)._UnitCount) && object.Equals((object) this._ThruputAdjustmentChildCount, (object) ((Container) obj)._ThruputAdjustmentChildCount)))) && (object.Equals((object) this._FactoryStartDateGMT, (object) ((Container) obj)._FactoryStartDateGMT) && object.Equals((object) this._LastActivityDate, (object) ((Container) obj)._LastActivityDate) && (object.Equals((object) this._ThisContainerLost, (object) ((Container) obj)._ThisContainerLost) && object.Equals((object) this._SamplingRequired, (object) ((Container) obj)._SamplingRequired)) && (object.Equals((object) this._ExpirationDate, (object) ((Container) obj)._ExpirationDate) && object.Equals((object) this._CurrentThruputUnitCount, (object) ((Container) obj)._CurrentThruputUnitCount) && (object.Equals((object) this._LastCompletionDate, (object) ((Container) obj)._LastCompletionDate) && object.Equals((object) this._DueDate, (object) ((Container) obj)._DueDate))) && (object.Equals((object) this._IssuedToContainer, (object) ((Container) obj)._IssuedToContainer) && object.Equals((object) this._OnHoldDate, (object) ((Container) obj)._OnHoldDate) && (object.Equals((object) this._ThruputAdjustmentUnitCount, (object) ((Container) obj)._ThruputAdjustmentUnitCount) && object.Equals((object) this._ProjectedDateGMT, (object) ((Container) obj)._ProjectedDateGMT)) && (object.Equals((object) this._RollupUnitCount, (object) ((Container) obj)._RollupUnitCount) && object.Equals((object) this._CurrentThruputChildCount, (object) ((Container) obj)._CurrentThruputChildCount) && (object.Equals((object) this._OriginalStartDateGMT, (object) ((Container) obj)._OriginalStartDateGMT) && object.Equals((object) this._ExpirationDateGMT, (object) ((Container) obj)._ExpirationDateGMT)))))) && (object.Equals((object) this._RequestDate, (object) ((Container) obj)._RequestDate) && object.Equals((object) this._LastActivityDateGMT, (object) ((Container) obj)._LastActivityDateGMT) && (this.CompareArrays((Array) this._ChildContainers, (Array) ((Container) obj)._ChildContainers) && object.Equals((object) this._ProjectedDate, (object) ((Container) obj)._ProjectedDate)) && (object.Equals((object) this._PlannedStartDateGMT, (object) ((Container) obj)._PlannedStartDateGMT) && object.Equals((object) this._IsContainer, (object) ((Container) obj)._IsContainer) && (object.Equals((object) this._IsNDO, (object) ((Container) obj)._IsNDO) && object.Equals((object) this._RequestDateGMT, (object) ((Container) obj)._RequestDateGMT))) && (object.Equals((object) this._IsRDO, (object) ((Container) obj)._IsRDO) && object.Equals((object) this._CurrentStepPass, (object) ((Container) obj)._CurrentStepPass) && (object.Equals((object) this._LastMoveDate, (object) ((Container) obj)._LastMoveDate) && object.Equals((object) this._ChildCount, (object) ((Container) obj)._ChildCount)) && (object.Equals((object) this._DueDateGMT, (object) ((Container) obj)._DueDateGMT) && object.Equals((object) this._WIPMsgDefMgr, (object) ((Container) obj)._WIPMsgDefMgr) && (object.Equals((object) this._SalesOrder, (object) ((Container) obj)._SalesOrder) && object.Equals((object) this._OriginalQty, (object) ((Container) obj)._OriginalQty)))) && (object.Equals((object) this._Priority, (object) ((Container) obj)._Priority) && object.Equals((object) this._Name, (object) ((Container) obj)._Name) && (object.Equals((object) this._Qty, (object) ((Container) obj)._Qty) && object.Equals((object) this._Level, (object) ((Container) obj)._Level)) && (object.Equals((object) this._ThruputAdjustmentQty, (object) ((Container) obj)._ThruputAdjustmentQty) && object.Equals((object) this._OriginalFactory, (object) ((Container) obj)._OriginalFactory) && (object.Equals((object) this._FactoryStartQty, (object) ((Container) obj)._FactoryStartQty) && object.Equals((object) this._ProjectedQty, (object) ((Container) obj)._ProjectedQty))) && (object.Equals((object) this._PlannedQty, (object) ((Container) obj)._PlannedQty) && object.Equals((object) this._MfgOrder, (object) ((Container) obj)._MfgOrder) && (object.Equals((object) this._CurrentThruputQty, (object) ((Container) obj)._CurrentThruputQty) && object.Equals((object) this._ContainerComments, (object) ((Container) obj)._ContainerComments)) && (object.Equals((object) this._PlannedProduct, (object) ((Container) obj)._PlannedProduct) && object.Equals((object) this._Owner, (object) ((Container) obj)._Owner) && (object.Equals((object) this._Product, (object) ((Container) obj)._Product) && object.Equals((object) this._Workstation, (object) ((Container) obj)._Workstation)))))) && base.Equals(obj);
    }

    public RevisionedObjectRef BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public Primitive<double> ProjectedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ProjectedQty2));
      }
    }

    public NamedObjectRef Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Customer));
      }
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public Enumeration<ContainerStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<double> ThruputAdjustmentQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputAdjustmentQty2));
      }
    }

    public Primitive<double> OriginalQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (OriginalQty2));
      }
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public RevisionedObjectRef BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BOM));
      }
    }

    public NamedObjectRef OriginalUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OriginalUOM2));
      }
    }

    public Primitive<double> FactoryStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FactoryStartQty2));
      }
    }

    public Primitive<double> PlannedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty2));
      }
    }

    public NamedObjectRef[] OpenNonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonconformanceReports), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (OpenNonconformanceReports));
      }
    }

    public NamedObjectRef[] OpenEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenEvents), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (OpenEvents));
      }
    }

    public NamedSubentityRef VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (VendorItem));
      }
    }

    public Camstar.WCF.ObjectStack.GateStatus[] GateStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateStatus), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.GateStatus[]) this.PropertyGet(nameof (GateStatus));
      }
    }

    public ContainerDetail Detail
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detail), (object) value);
      }
      get
      {
        return (ContainerDetail) this.PropertyGet(nameof (Detail));
      }
    }

    public SpecStatus SpecStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStatus), (object) value);
      }
      get
      {
        return (SpecStatus) this.PropertyGet(nameof (SpecStatus));
      }
    }

    public NamedObjectRef OriginalUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OriginalUOM));
      }
    }

    public NamedObjectRef FactoryStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FactoryStartUOM2));
      }
    }

    public NamedObjectRef PlannedQtyUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedQtyUOM2));
      }
    }

    public Primitive<double> CurrentThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CurrentThruputQty2));
      }
    }

    public NamedObjectRef[] NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public NamedObjectRef PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public NamedObjectRef StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartReason));
      }
    }

    public ContainerMaterialListItem[] ContainerMaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerMaterialList), (object) value);
      }
      get
      {
        return (ContainerMaterialListItem[]) this.PropertyGet(nameof (ContainerMaterialList));
      }
    }

    public NamedObjectRef FactoryStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FactoryStartUOM));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public Primitive<int> RelativePriority
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelativePriority), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RelativePriority));
      }
    }

    public NamedSubentityRef[] DataPointCollections
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollections), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (DataPointCollections));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Camstar.WCF.ObjectStack.ContainerSampleData[] ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ContainerSampleData[]) this.PropertyGet(nameof (ContainerSampleData));
      }
    }

    public UserAttribute[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute[]) this.PropertyGet(nameof (Attributes));
      }
    }

    public Camstar.WCF.ObjectStack.AttachDocumentDetails[] AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.AttachDocumentDetails[]) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Primitive<DateTime> OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Primitive<int> InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (InQualityControl));
      }
    }

    public Primitive<DateTime> LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Primitive<DateTime> FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Primitive<bool> SamplingPassed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPassed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SamplingPassed));
      }
    }

    public Primitive<DateTime> PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Primitive<int> CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }

    public Primitive<DateTime> LastCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletionDateGMT));
      }
    }

    public ContainerRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Parent));
      }
    }

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ThruputAdjustmentChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ThruputAdjustmentChildCount));
      }
    }

    public Primitive<DateTime> FactoryStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FactoryStartDateGMT));
      }
    }

    public Primitive<DateTime> LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Primitive<bool> ThisContainerLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerLost), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThisContainerLost));
      }
    }

    public Primitive<bool> SamplingRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SamplingRequired));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Primitive<int> CurrentThruputUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputUnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentThruputUnitCount));
      }
    }

    public Primitive<DateTime> LastCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletionDate));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public ContainerRef IssuedToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedToContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (IssuedToContainer));
      }
    }

    public Primitive<DateTime> OnHoldDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OnHoldDate));
      }
    }

    public Primitive<int> ThruputAdjustmentUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentUnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ThruputAdjustmentUnitCount));
      }
    }

    public Primitive<DateTime> ProjectedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ProjectedDateGMT));
      }
    }

    public Primitive<int> RollupUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupUnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RollupUnitCount));
      }
    }

    public Primitive<int> CurrentThruputChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentThruputChildCount));
      }
    }

    public Primitive<DateTime> OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDateGMT));
      }
    }

    public Primitive<DateTime> ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Primitive<DateTime> RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RequestDate));
      }
    }

    public Primitive<DateTime> LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Container[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Container[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Primitive<DateTime> ProjectedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ProjectedDate));
      }
    }

    public Primitive<DateTime> PlannedStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (PlannedStartDateGMT));
      }
    }

    public Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Primitive<bool> IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Primitive<DateTime> RequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RequestDateGMT));
      }
    }

    public Primitive<bool> IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Primitive<int> CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentStepPass));
      }
    }

    public Primitive<DateTime> LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Primitive<DateTime> DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public WIPMsgDefMgr WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public NamedObjectRef SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SalesOrder));
      }
    }

    public Primitive<double> OriginalQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (OriginalQty));
      }
    }

    public NamedObjectRef Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Priority));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public NamedObjectRef Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Level));
      }
    }

    public Primitive<double> ThruputAdjustmentQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputAdjustmentQty));
      }
    }

    public NamedObjectRef OriginalFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OriginalFactory));
      }
    }

    public Primitive<double> FactoryStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FactoryStartQty));
      }
    }

    public Primitive<double> ProjectedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ProjectedQty));
      }
    }

    public Primitive<double> PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Primitive<double> CurrentThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CurrentThruputQty));
      }
    }

    public Primitive<string> ContainerComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerComments));
      }
    }

    public RevisionedObjectRef PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }
  }
}
