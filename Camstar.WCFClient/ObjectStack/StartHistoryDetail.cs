// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartHistoryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BatchStartHistoryDetail))]
  [KnownType(typeof (MaterialContainerHistoryDetail))]
  [KnownType(typeof (GroupHistoryDetail))]
  [KnownType(typeof (UnitHistoryDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StartHistoryDetail : HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedQtyUOM")]
    protected NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedQtyUOM2")]
    protected NamedObjectRef _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Attributes")]
    protected SubentityRef[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_ExpirationDateGMT")]
    protected Primitive<DateTime> _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedStartDate")]
    protected Primitive<DateTime> _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedStartDateGMT")]
    protected Primitive<DateTime> _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_InQualityControl")]
    protected Primitive<int> _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_SamplingRequired")]
    protected Primitive<bool> _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_PlannedQty")]
    protected Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_ContainerComments")]
    protected Primitive<string> _ContainerComments;

    public override bool Equals(object obj)
    {
      return obj is StartHistoryDetail && object.Equals((object) this._PlannedQty2, (object) ((StartHistoryDetail) obj)._PlannedQty2) && (object.Equals((object) this._Qty2, (object) ((StartHistoryDetail) obj)._Qty2) && object.Equals((object) this._PlannedQtyUOM, (object) ((StartHistoryDetail) obj)._PlannedQtyUOM)) && (object.Equals((object) this._StartReason, (object) ((StartHistoryDetail) obj)._StartReason) && object.Equals((object) this._ExportImportKey, (object) ((StartHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._UOM, (object) ((StartHistoryDetail) obj)._UOM) && object.Equals((object) this._PlannedQtyUOM2, (object) ((StartHistoryDetail) obj)._PlannedQtyUOM2))) && (object.Equals((object) this._BillOfProcess, (object) ((StartHistoryDetail) obj)._BillOfProcess) && object.Equals((object) this._UOM2, (object) ((StartHistoryDetail) obj)._UOM2) && (object.Equals((object) this._Customer, (object) ((StartHistoryDetail) obj)._Customer) && object.Equals((object) this._VendorItem, (object) ((StartHistoryDetail) obj)._VendorItem)) && (object.Equals((object) this._SamplingLot, (object) ((StartHistoryDetail) obj)._SamplingLot) && object.Equals((object) this._Carrier, (object) ((StartHistoryDetail) obj)._Carrier) && (this.CompareArrays((Array) this._Attributes, (Array) ((StartHistoryDetail) obj)._Attributes) && object.Equals((object) this._UnitCount, (object) ((StartHistoryDetail) obj)._UnitCount)))) && (object.Equals((object) this._Container, (object) ((StartHistoryDetail) obj)._Container) && object.Equals((object) this._ExpirationDateGMT, (object) ((StartHistoryDetail) obj)._ExpirationDateGMT) && (object.Equals((object) this._PlannedStartDate, (object) ((StartHistoryDetail) obj)._PlannedStartDate) && object.Equals((object) this._PlannedStartDateGMT, (object) ((StartHistoryDetail) obj)._PlannedStartDateGMT)) && (object.Equals((object) this._ExpirationDate, (object) ((StartHistoryDetail) obj)._ExpirationDate) && object.Equals((object) this._InQualityControl, (object) ((StartHistoryDetail) obj)._InQualityControl) && (object.Equals((object) this._RequestDate, (object) ((StartHistoryDetail) obj)._RequestDate) && object.Equals((object) this._DueDate, (object) ((StartHistoryDetail) obj)._DueDate))) && (object.Equals((object) this._SamplingRequired, (object) ((StartHistoryDetail) obj)._SamplingRequired) && object.Equals((object) this._DueDateGMT, (object) ((StartHistoryDetail) obj)._DueDateGMT) && (object.Equals((object) this._ChildCount, (object) ((StartHistoryDetail) obj)._ChildCount) && object.Equals((object) this._HistoryId, (object) ((StartHistoryDetail) obj)._HistoryId)) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((StartHistoryDetail) obj)._WorkflowStack) && object.Equals((object) this._Resource, (object) ((StartHistoryDetail) obj)._Resource) && (object.Equals((object) this._Product, (object) ((StartHistoryDetail) obj)._Product) && object.Equals((object) this._Location, (object) ((StartHistoryDetail) obj)._Location))))) && (object.Equals((object) this._Operation, (object) ((StartHistoryDetail) obj)._Operation) && object.Equals((object) this._Workstation, (object) ((StartHistoryDetail) obj)._Workstation) && (object.Equals((object) this._SalesOrder, (object) ((StartHistoryDetail) obj)._SalesOrder) && object.Equals((object) this._PlannedProduct, (object) ((StartHistoryDetail) obj)._PlannedProduct)) && (object.Equals((object) this._Qty, (object) ((StartHistoryDetail) obj)._Qty) && object.Equals((object) this._WorkflowStep, (object) ((StartHistoryDetail) obj)._WorkflowStep) && (object.Equals((object) this._PlannedQty, (object) ((StartHistoryDetail) obj)._PlannedQty) && object.Equals((object) this._Owner, (object) ((StartHistoryDetail) obj)._Owner))) && (object.Equals((object) this._MfgOrder, (object) ((StartHistoryDetail) obj)._MfgOrder) && object.Equals((object) this._Priority, (object) ((StartHistoryDetail) obj)._Priority) && object.Equals((object) this._ContainerComments, (object) ((StartHistoryDetail) obj)._ContainerComments))) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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

    public SubentityRef[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (Attributes));
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
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

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
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

    public NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
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
  }
}
