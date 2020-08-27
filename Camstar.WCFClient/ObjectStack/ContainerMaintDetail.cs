// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintDetail
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
  public class ContainerMaintDetail : ChgContainerAttrDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PreHistoryDetail")]
    protected new SubentityRef _PreHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PlannedQtyUOM2")]
    protected NamedObjectRef _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_RelativePriority")]
    protected Primitive<int> _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PlannedQtyUOM")]
    protected NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_SamplingRequired")]
    protected Primitive<bool> _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_ExpirationDateGMT")]
    protected Primitive<DateTime> _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_RequestDateGMT")]
    protected Primitive<DateTime> _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Level")]
    protected NamedObjectRef _Level;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_ContainerComments")]
    protected Primitive<string> _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PlannedQty")]
    protected Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;

    public override bool Equals(object obj)
    {
      return obj is ContainerMaintDetail && object.Equals((object) this._UOM, (object) ((ContainerMaintDetail) obj)._UOM) && (object.Equals((object) this._UOM2, (object) ((ContainerMaintDetail) obj)._UOM2) && object.Equals((object) this._PreHistoryDetail, (object) ((ContainerMaintDetail) obj)._PreHistoryDetail)) && (object.Equals((object) this._PlannedQtyUOM2, (object) ((ContainerMaintDetail) obj)._PlannedQtyUOM2) && object.Equals((object) this._VendorItem, (object) ((ContainerMaintDetail) obj)._VendorItem) && (object.Equals((object) this._RelativePriority, (object) ((ContainerMaintDetail) obj)._RelativePriority) && object.Equals((object) this._PlannedQty2, (object) ((ContainerMaintDetail) obj)._PlannedQty2))) && (object.Equals((object) this._Customer, (object) ((ContainerMaintDetail) obj)._Customer) && object.Equals((object) this._PlannedQtyUOM, (object) ((ContainerMaintDetail) obj)._PlannedQtyUOM) && (object.Equals((object) this._BillOfProcess, (object) ((ContainerMaintDetail) obj)._BillOfProcess) && object.Equals((object) this._StartReason, (object) ((ContainerMaintDetail) obj)._StartReason)) && (object.Equals((object) this._SamplingLot, (object) ((ContainerMaintDetail) obj)._SamplingLot) && object.Equals((object) this._ExpirationDate, (object) ((ContainerMaintDetail) obj)._ExpirationDate) && (object.Equals((object) this._DueDate, (object) ((ContainerMaintDetail) obj)._DueDate) && object.Equals((object) this._SamplingRequired, (object) ((ContainerMaintDetail) obj)._SamplingRequired)))) && (object.Equals((object) this._RequestDate, (object) ((ContainerMaintDetail) obj)._RequestDate) && object.Equals((object) this._ExpirationDateGMT, (object) ((ContainerMaintDetail) obj)._ExpirationDateGMT) && (object.Equals((object) this._DueDateGMT, (object) ((ContainerMaintDetail) obj)._DueDateGMT) && object.Equals((object) this._RequestDateGMT, (object) ((ContainerMaintDetail) obj)._RequestDateGMT)) && (object.Equals((object) this._Level, (object) ((ContainerMaintDetail) obj)._Level) && object.Equals((object) this._Owner, (object) ((ContainerMaintDetail) obj)._Owner) && (object.Equals((object) this._Priority, (object) ((ContainerMaintDetail) obj)._Priority) && object.Equals((object) this._MfgOrder, (object) ((ContainerMaintDetail) obj)._MfgOrder))) && (object.Equals((object) this._Resource, (object) ((ContainerMaintDetail) obj)._Resource) && object.Equals((object) this._ContainerComments, (object) ((ContainerMaintDetail) obj)._ContainerComments) && (object.Equals((object) this._Location, (object) ((ContainerMaintDetail) obj)._Location) && object.Equals((object) this._Name, (object) ((ContainerMaintDetail) obj)._Name)) && (object.Equals((object) this._SalesOrder, (object) ((ContainerMaintDetail) obj)._SalesOrder) && object.Equals((object) this._Factory, (object) ((ContainerMaintDetail) obj)._Factory) && (object.Equals((object) this._Product, (object) ((ContainerMaintDetail) obj)._Product) && object.Equals((object) this._PlannedQty, (object) ((ContainerMaintDetail) obj)._PlannedQty))))) && object.Equals((object) this._PlannedProduct, (object) ((ContainerMaintDetail) obj)._PlannedProduct) && base.Equals(obj);
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

    public new SubentityRef PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (PreHistoryDetail));
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

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
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
  }
}
