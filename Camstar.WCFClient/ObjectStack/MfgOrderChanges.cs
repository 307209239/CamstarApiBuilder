// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderChanges
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
  public class MfgOrderChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_OrderStatus")]
    protected NamedObjectRef _OrderStatus;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_OrderType")]
    protected NamedObjectRef _OrderType;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ERPBOM")]
    protected RevisionedObjectRef _ERPBOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ERPRoute")]
    protected RevisionedObjectRef _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_MaterialList")]
    protected MfgOrderMaterialListItmChanges[] _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Attributes")]
    protected UserAttributeChanges[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ContainerNumberingRule")]
    protected NamedObjectRef _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_PlannedStartDate")]
    protected Primitive<DateTime> _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ExternallyControlled")]
    protected Primitive<bool> _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_PlannedStartDateGMT")]
    protected Primitive<DateTime> _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_PlannedCompletionDateGMT")]
    protected Primitive<DateTime> _PlannedCompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ReleaseDateGMT")]
    protected Primitive<DateTime> _ReleaseDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_PlannedCompletionDate")]
    protected Primitive<DateTime> _PlannedCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ReleaseDate")]
    protected Primitive<DateTime> _ReleaseDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_DefaultLot")]
    protected Primitive<string> _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Containers")]
    protected Primitive<string>[] _Containers;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_DefaultPutawayStockPoint")]
    protected Primitive<string> _DefaultPutawayStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_ReportingFactory")]
    protected NamedObjectRef _ReportingFactory;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_BeginProduct")]
    protected RevisionedObjectRef _BeginProduct;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is MfgOrderChanges && object.Equals((object) this._OrderStatus, (object) ((MfgOrderChanges) obj)._OrderStatus) && (object.Equals((object) this._OrderType, (object) ((MfgOrderChanges) obj)._OrderType) && object.Equals((object) this._ERPBOM, (object) ((MfgOrderChanges) obj)._ERPBOM)) && (object.Equals((object) this._UOM2, (object) ((MfgOrderChanges) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((MfgOrderChanges) obj)._UOM) && (object.Equals((object) this._Qty2, (object) ((MfgOrderChanges) obj)._Qty2) && object.Equals((object) this._WIPMsgDefMgr, (object) ((MfgOrderChanges) obj)._WIPMsgDefMgr))) && (object.Equals((object) this._ERPRoute, (object) ((MfgOrderChanges) obj)._ERPRoute) && this.CompareArrays((Array) this._MaterialList, (Array) ((MfgOrderChanges) obj)._MaterialList) && (object.Equals((object) this._BillOfProcess, (object) ((MfgOrderChanges) obj)._BillOfProcess) && this.CompareArrays((Array) this._Attributes, (Array) ((MfgOrderChanges) obj)._Attributes)) && (object.Equals((object) this._ContainerNumberingRule, (object) ((MfgOrderChanges) obj)._ContainerNumberingRule) && object.Equals((object) this._PlannedStartDate, (object) ((MfgOrderChanges) obj)._PlannedStartDate) && (object.Equals((object) this._ExternallyControlled, (object) ((MfgOrderChanges) obj)._ExternallyControlled) && object.Equals((object) this._PlannedStartDateGMT, (object) ((MfgOrderChanges) obj)._PlannedStartDateGMT)))) && (object.Equals((object) this._PlannedCompletionDateGMT, (object) ((MfgOrderChanges) obj)._PlannedCompletionDateGMT) && object.Equals((object) this._ReleaseDateGMT, (object) ((MfgOrderChanges) obj)._ReleaseDateGMT) && (object.Equals((object) this._PlannedCompletionDate, (object) ((MfgOrderChanges) obj)._PlannedCompletionDate) && object.Equals((object) this._ReleaseDate, (object) ((MfgOrderChanges) obj)._ReleaseDate)) && (object.Equals((object) this._DefaultLot, (object) ((MfgOrderChanges) obj)._DefaultLot) && object.Equals((object) this._ObjectToChange, (object) ((MfgOrderChanges) obj)._ObjectToChange) && (object.Equals((object) this._Name, (object) ((MfgOrderChanges) obj)._Name) && object.Equals((object) this._Priority, (object) ((MfgOrderChanges) obj)._Priority))) && (this.CompareArrays((Array) this._Containers, (Array) ((MfgOrderChanges) obj)._Containers) && object.Equals((object) this._Qty, (object) ((MfgOrderChanges) obj)._Qty) && (object.Equals((object) this._DefaultPutawayStockPoint, (object) ((MfgOrderChanges) obj)._DefaultPutawayStockPoint) && object.Equals((object) this._ReportingFactory, (object) ((MfgOrderChanges) obj)._ReportingFactory)) && (object.Equals((object) this._BeginProduct, (object) ((MfgOrderChanges) obj)._BeginProduct) && object.Equals((object) this._Product, (object) ((MfgOrderChanges) obj)._Product)))) && base.Equals(obj);
    }

    public NamedObjectRef OrderStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderStatus), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OrderStatus));
      }
    }

    public NamedObjectRef OrderType
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OrderType));
      }
    }

    public RevisionedObjectRef ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPBOM));
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

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public RevisionedObjectRef ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public MfgOrderMaterialListItmChanges[] MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MfgOrderMaterialListItmChanges[]) this.PropertyGet(nameof (MaterialList));
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

    public UserAttributeChanges[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges[]) this.PropertyGet(nameof (Attributes));
      }
    }

    public NamedObjectRef ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerNumberingRule));
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

    public Primitive<bool> ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ExternallyControlled));
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

    public Primitive<DateTime> PlannedCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (PlannedCompletionDateGMT));
      }
    }

    public Primitive<DateTime> ReleaseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReleaseDateGMT));
      }
    }

    public Primitive<DateTime> PlannedCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (PlannedCompletionDate));
      }
    }

    public Primitive<DateTime> ReleaseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReleaseDate));
      }
    }

    public Primitive<string> DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
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

    public Primitive<string>[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (Containers));
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

    public Primitive<string> DefaultPutawayStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPutawayStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultPutawayStockPoint));
      }
    }

    public NamedObjectRef ReportingFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReportingFactory));
      }
    }

    public RevisionedObjectRef BeginProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BeginProduct));
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
  }
}
