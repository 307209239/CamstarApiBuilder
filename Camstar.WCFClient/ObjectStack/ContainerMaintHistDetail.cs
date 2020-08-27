// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintHistDetail
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
  public class ContainerMaintHistDetail : ChgContainerAttrHistDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_RelativePriority")]
    protected Primitive<int> _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_PlannedQtyUOM")]
    protected NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_PlannedQtyUOM2")]
    protected NamedObjectRef _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_IsPreHistory")]
    protected new Primitive<bool> _IsPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_RequestDateGMT")]
    protected Primitive<DateTime> _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_PlannedQty")]
    protected Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_ContainerComments")]
    protected Primitive<string> _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Level")]
    protected NamedObjectRef _Level;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistDetail_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ContainerMaintHistDetail && object.Equals((object) this._ExportImportKey, (object) ((ContainerMaintHistDetail) obj)._ExportImportKey) && (object.Equals((object) this._UOM2, (object) ((ContainerMaintHistDetail) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((ContainerMaintHistDetail) obj)._UOM)) && (object.Equals((object) this._RelativePriority, (object) ((ContainerMaintHistDetail) obj)._RelativePriority) && object.Equals((object) this._Customer, (object) ((ContainerMaintHistDetail) obj)._Customer) && (object.Equals((object) this._PlannedQtyUOM, (object) ((ContainerMaintHistDetail) obj)._PlannedQtyUOM) && object.Equals((object) this._PlannedQtyUOM2, (object) ((ContainerMaintHistDetail) obj)._PlannedQtyUOM2))) && (object.Equals((object) this._StartReason, (object) ((ContainerMaintHistDetail) obj)._StartReason) && object.Equals((object) this._PlannedQty2, (object) ((ContainerMaintHistDetail) obj)._PlannedQty2) && (object.Equals((object) this._VendorItem, (object) ((ContainerMaintHistDetail) obj)._VendorItem) && object.Equals((object) this._BillOfProcess, (object) ((ContainerMaintHistDetail) obj)._BillOfProcess)) && (object.Equals((object) this._IsPreHistory, (object) ((ContainerMaintHistDetail) obj)._IsPreHistory) && object.Equals((object) this._HistoryId, (object) ((ContainerMaintHistDetail) obj)._HistoryId) && (object.Equals((object) this._RequestDate, (object) ((ContainerMaintHistDetail) obj)._RequestDate) && object.Equals((object) this._DueDateGMT, (object) ((ContainerMaintHistDetail) obj)._DueDateGMT)))) && (object.Equals((object) this._DueDate, (object) ((ContainerMaintHistDetail) obj)._DueDate) && object.Equals((object) this._RequestDateGMT, (object) ((ContainerMaintHistDetail) obj)._RequestDateGMT) && (object.Equals((object) this._ExpirationDate, (object) ((ContainerMaintHistDetail) obj)._ExpirationDate) && object.Equals((object) this._SalesOrder, (object) ((ContainerMaintHistDetail) obj)._SalesOrder)) && (object.Equals((object) this._PlannedQty, (object) ((ContainerMaintHistDetail) obj)._PlannedQty) && object.Equals((object) this._Owner, (object) ((ContainerMaintHistDetail) obj)._Owner) && (object.Equals((object) this._Location, (object) ((ContainerMaintHistDetail) obj)._Location) && object.Equals((object) this._Factory, (object) ((ContainerMaintHistDetail) obj)._Factory))) && (object.Equals((object) this._ContainerComments, (object) ((ContainerMaintHistDetail) obj)._ContainerComments) && object.Equals((object) this._Priority, (object) ((ContainerMaintHistDetail) obj)._Priority) && (object.Equals((object) this._PlannedProduct, (object) ((ContainerMaintHistDetail) obj)._PlannedProduct) && object.Equals((object) this._MfgOrder, (object) ((ContainerMaintHistDetail) obj)._MfgOrder)) && (object.Equals((object) this._Level, (object) ((ContainerMaintHistDetail) obj)._Level) && object.Equals((object) this._Resource, (object) ((ContainerMaintHistDetail) obj)._Resource) && (object.Equals((object) this._Product, (object) ((ContainerMaintHistDetail) obj)._Product) && object.Equals((object) this._Name, (object) ((ContainerMaintHistDetail) obj)._Name))))) && base.Equals(obj);
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

    public new Primitive<bool> IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPreHistory));
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
  }
}
