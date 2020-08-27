// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerAsParent
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CurrentContainerStatus))]
  [Serializable]
  public class ViewContainerAsParent : ContainerStatusDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PlannedUOM")]
    protected new NamedObjectRef _PlannedUOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Customer")]
    protected new NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PlannedUOM2")]
    protected new NamedObjectRef _PlannedUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PlannedQty2")]
    protected new Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Status")]
    protected new Enumeration<ContainerStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_HoldReason")]
    protected new NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_CurrentThruputQty2")]
    protected new Primitive<double> _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ContainerStatus")]
    protected Enumeration<ContainerStatusExtEnum, int> _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_OriginalStartDate")]
    protected new Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_LastMoveDate")]
    protected new Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_LastActivityDate")]
    protected new Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ProjectedDate")]
    protected new Primitive<DateTime> _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_DueDate")]
    protected new Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_RequestDate")]
    protected new Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_InProcess")]
    protected new Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Step")]
    protected new NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_HoldReasonName")]
    protected Primitive<string> _HoldReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ProductName")]
    protected new Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ContainerLevelName")]
    protected new Primitive<string> _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Operation")]
    protected new NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_CurrentThruputQty")]
    protected new Primitive<double> _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_StatusName")]
    protected new Primitive<string> _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ProductDescription")]
    protected new Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ResourceName")]
    protected new Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ReworkReason")]
    protected new NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Location")]
    protected new NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_DocumentEntries")]
    protected DocumentEntry[] _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_WorkflowRev")]
    protected new Primitive<string> _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_StartReasonName")]
    protected Primitive<string> _StartReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PlannedQty")]
    protected new Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ProductRev")]
    protected new Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PriorityCode")]
    protected new NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_SalesOrderName")]
    protected Primitive<string> _SalesOrderName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ContainerLevel")]
    protected new NamedObjectRef _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_WorkflowIsRevOfRcd")]
    protected new Primitive<bool> _WorkflowIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_StepName")]
    protected new Primitive<string> _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_MfgOrderName")]
    protected Primitive<string> _MfgOrderName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Specification")]
    protected new Primitive<string> _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ProductIsRevOfRcd")]
    protected new Primitive<bool> _ProductIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PriorityCodeName")]
    protected Primitive<string> _PriorityCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_UOM2Name")]
    protected Primitive<string> _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_SpecRevision")]
    protected new Primitive<string> _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_ContainerComments")]
    protected new Primitive<string> _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_SalesOrder")]
    protected new NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_PlannedProduct")]
    protected new RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_OwnerName")]
    protected Primitive<string> _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_NextOperation")]
    protected new Primitive<string> _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_SpecIsRevOfRcd")]
    protected new Primitive<bool> _SpecIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_CustomerName")]
    protected Primitive<string> _CustomerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_LocationName")]
    protected Primitive<string> _LocationName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_OperationName")]
    protected new Primitive<string> _OperationName;

    public override bool Equals(object obj)
    {
      return obj is ViewContainerAsParent && object.Equals((object) this._PlannedUOM, (object) ((ViewContainerAsParent) obj)._PlannedUOM) && (object.Equals((object) this._UOM, (object) ((ViewContainerAsParent) obj)._UOM) && object.Equals((object) this._Customer, (object) ((ViewContainerAsParent) obj)._Customer)) && (object.Equals((object) this._StartReason, (object) ((ViewContainerAsParent) obj)._StartReason) && object.Equals((object) this._PlannedUOM2, (object) ((ViewContainerAsParent) obj)._PlannedUOM2) && (object.Equals((object) this._PlannedQty2, (object) ((ViewContainerAsParent) obj)._PlannedQty2) && object.Equals((object) this._Status, (object) ((ViewContainerAsParent) obj)._Status))) && (object.Equals((object) this._HoldReason, (object) ((ViewContainerAsParent) obj)._HoldReason) && object.Equals((object) this._CurrentThruputQty2, (object) ((ViewContainerAsParent) obj)._CurrentThruputQty2) && (object.Equals((object) this._Qty2, (object) ((ViewContainerAsParent) obj)._Qty2) && object.Equals((object) this._Spec, (object) ((ViewContainerAsParent) obj)._Spec)) && (object.Equals((object) this._UOM2, (object) ((ViewContainerAsParent) obj)._UOM2) && object.Equals((object) this._ContainerStatus, (object) ((ViewContainerAsParent) obj)._ContainerStatus) && (object.Equals((object) this._OriginalStartDate, (object) ((ViewContainerAsParent) obj)._OriginalStartDate) && object.Equals((object) this._Container, (object) ((ViewContainerAsParent) obj)._Container)))) && (object.Equals((object) this._LastMoveDate, (object) ((ViewContainerAsParent) obj)._LastMoveDate) && object.Equals((object) this._LastActivityDate, (object) ((ViewContainerAsParent) obj)._LastActivityDate) && (object.Equals((object) this._ProjectedDate, (object) ((ViewContainerAsParent) obj)._ProjectedDate) && object.Equals((object) this._DueDate, (object) ((ViewContainerAsParent) obj)._DueDate)) && (object.Equals((object) this._RequestDate, (object) ((ViewContainerAsParent) obj)._RequestDate) && object.Equals((object) this._InProcess, (object) ((ViewContainerAsParent) obj)._InProcess) && (object.Equals((object) this._Step, (object) ((ViewContainerAsParent) obj)._Step) && object.Equals((object) this._HoldReasonName, (object) ((ViewContainerAsParent) obj)._HoldReasonName))) && (object.Equals((object) this._ProductName, (object) ((ViewContainerAsParent) obj)._ProductName) && object.Equals((object) this._ContainerLevelName, (object) ((ViewContainerAsParent) obj)._ContainerLevelName) && (object.Equals((object) this._Operation, (object) ((ViewContainerAsParent) obj)._Operation) && object.Equals((object) this._CurrentThruputQty, (object) ((ViewContainerAsParent) obj)._CurrentThruputQty)) && (object.Equals((object) this._StatusName, (object) ((ViewContainerAsParent) obj)._StatusName) && object.Equals((object) this._ProductDescription, (object) ((ViewContainerAsParent) obj)._ProductDescription) && (object.Equals((object) this._ResourceName, (object) ((ViewContainerAsParent) obj)._ResourceName) && object.Equals((object) this._Resource, (object) ((ViewContainerAsParent) obj)._Resource))))) && (object.Equals((object) this._ReworkReason, (object) ((ViewContainerAsParent) obj)._ReworkReason) && object.Equals((object) this._Location, (object) ((ViewContainerAsParent) obj)._Location) && (object.Equals((object) this._Factory, (object) ((ViewContainerAsParent) obj)._Factory) && this.CompareArrays((Array) this._DocumentEntries, (Array) ((ViewContainerAsParent) obj)._DocumentEntries)) && (object.Equals((object) this._Owner, (object) ((ViewContainerAsParent) obj)._Owner) && object.Equals((object) this._WorkflowRev, (object) ((ViewContainerAsParent) obj)._WorkflowRev) && (object.Equals((object) this._StartReasonName, (object) ((ViewContainerAsParent) obj)._StartReasonName) && object.Equals((object) this._PlannedQty, (object) ((ViewContainerAsParent) obj)._PlannedQty))) && (object.Equals((object) this._ProductRev, (object) ((ViewContainerAsParent) obj)._ProductRev) && object.Equals((object) this._PriorityCode, (object) ((ViewContainerAsParent) obj)._PriorityCode) && (object.Equals((object) this._SalesOrderName, (object) ((ViewContainerAsParent) obj)._SalesOrderName) && object.Equals((object) this._ContainerName, (object) ((ViewContainerAsParent) obj)._ContainerName)) && (object.Equals((object) this._ContainerLevel, (object) ((ViewContainerAsParent) obj)._ContainerLevel) && object.Equals((object) this._WorkflowIsRevOfRcd, (object) ((ViewContainerAsParent) obj)._WorkflowIsRevOfRcd) && (object.Equals((object) this._MfgOrder, (object) ((ViewContainerAsParent) obj)._MfgOrder) && object.Equals((object) this._StepName, (object) ((ViewContainerAsParent) obj)._StepName)))) && (object.Equals((object) this._MfgOrderName, (object) ((ViewContainerAsParent) obj)._MfgOrderName) && object.Equals((object) this._Specification, (object) ((ViewContainerAsParent) obj)._Specification) && (object.Equals((object) this._ProductIsRevOfRcd, (object) ((ViewContainerAsParent) obj)._ProductIsRevOfRcd) && object.Equals((object) this._Qty, (object) ((ViewContainerAsParent) obj)._Qty)) && (object.Equals((object) this._UOMName, (object) ((ViewContainerAsParent) obj)._UOMName) && object.Equals((object) this._PriorityCodeName, (object) ((ViewContainerAsParent) obj)._PriorityCodeName) && (object.Equals((object) this._UOM2Name, (object) ((ViewContainerAsParent) obj)._UOM2Name) && object.Equals((object) this._SpecRevision, (object) ((ViewContainerAsParent) obj)._SpecRevision))) && (object.Equals((object) this._ContainerComments, (object) ((ViewContainerAsParent) obj)._ContainerComments) && object.Equals((object) this._SalesOrder, (object) ((ViewContainerAsParent) obj)._SalesOrder) && (object.Equals((object) this._PlannedProduct, (object) ((ViewContainerAsParent) obj)._PlannedProduct) && object.Equals((object) this._OwnerName, (object) ((ViewContainerAsParent) obj)._OwnerName)) && (object.Equals((object) this._NextOperation, (object) ((ViewContainerAsParent) obj)._NextOperation) && object.Equals((object) this._SpecIsRevOfRcd, (object) ((ViewContainerAsParent) obj)._SpecIsRevOfRcd) && (object.Equals((object) this._Product, (object) ((ViewContainerAsParent) obj)._Product) && object.Equals((object) this._Workflow, (object) ((ViewContainerAsParent) obj)._Workflow)))))) && (object.Equals((object) this._CustomerName, (object) ((ViewContainerAsParent) obj)._CustomerName) && object.Equals((object) this._LocationName, (object) ((ViewContainerAsParent) obj)._LocationName) && object.Equals((object) this._OperationName, (object) ((ViewContainerAsParent) obj)._OperationName)) && base.Equals(obj);
    }

    public new NamedObjectRef PlannedUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedUOM));
      }
    }

    public new NamedObjectRef UOM
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

    public new NamedObjectRef Customer
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

    public new NamedObjectRef StartReason
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

    public new NamedObjectRef PlannedUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedUOM2));
      }
    }

    public new Primitive<double> PlannedQty2
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

    public new Enumeration<ContainerStatusEnum, int> Status
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

    public new NamedObjectRef HoldReason
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

    public new Primitive<double> CurrentThruputQty2
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

    public new Primitive<double> Qty2
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

    public new RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new NamedObjectRef UOM2
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

    public Enumeration<ContainerStatusExtEnum, int> ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusExtEnum, int>) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public new Primitive<DateTime> OriginalStartDate
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

    public new ContainerRef Container
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

    public new Primitive<DateTime> LastMoveDate
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

    public new Primitive<DateTime> LastActivityDate
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

    public new Primitive<DateTime> ProjectedDate
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

    public new Primitive<DateTime> DueDate
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

    public new Primitive<DateTime> RequestDate
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

    public new Primitive<bool> InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InProcess));
      }
    }

    public new NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public Primitive<string> HoldReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReasonName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HoldReasonName));
      }
    }

    public new Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Primitive<string> ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerLevelName));
      }
    }

    public new NamedObjectRef Operation
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

    public new Primitive<double> CurrentThruputQty
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

    public new Primitive<string> StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusName));
      }
    }

    public new Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public new Primitive<string> ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceName));
      }
    }

    public new NamedObjectRef Resource
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

    public new NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public new NamedSubentityRef Location
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

    public new NamedObjectRef Factory
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

    public DocumentEntry[] DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry[]) this.PropertyGet(nameof (DocumentEntries));
      }
    }

    public new NamedObjectRef Owner
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

    public new Primitive<string> WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public Primitive<string> StartReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReasonName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StartReasonName));
      }
    }

    public new Primitive<double> PlannedQty
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

    public new Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }

    public new NamedObjectRef PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public Primitive<string> SalesOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrderName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SalesOrderName));
      }
    }

    public new Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new NamedObjectRef ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new Primitive<bool> WorkflowIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowIsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (WorkflowIsRevOfRcd));
      }
    }

    public new NamedObjectRef MfgOrder
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

    public new Primitive<string> StepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StepName));
      }
    }

    public Primitive<string> MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MfgOrderName));
      }
    }

    public new Primitive<string> Specification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Specification), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Specification));
      }
    }

    public new Primitive<bool> ProductIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductIsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProductIsRevOfRcd));
      }
    }

    public new Primitive<double> Qty
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

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }

    public Primitive<string> PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public Primitive<string> UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public new Primitive<string> SpecRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecRevision));
      }
    }

    public new Primitive<string> ContainerComments
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

    public new NamedObjectRef SalesOrder
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

    public new RevisionedObjectRef PlannedProduct
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

    public Primitive<string> OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerName));
      }
    }

    public new Primitive<string> NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NextOperation));
      }
    }

    public new Primitive<bool> SpecIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecIsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SpecIsRevOfRcd));
      }
    }

    public new RevisionedObjectRef Product
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

    public new RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public Primitive<string> CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerName));
      }
    }

    public Primitive<string> LocationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LocationName));
      }
    }

    public new Primitive<string> OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OperationName));
      }
    }
  }
}
