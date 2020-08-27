// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeAttributeAsParent))]
  [KnownType(typeof (ViewContainerAsParent))]
  [KnownType(typeof (ContainerSearchDetail))]
  [Serializable]
  public class ContainerStatusDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PlannedUOM")]
    protected NamedObjectRef _PlannedUOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PlannedUOM2")]
    protected NamedObjectRef _PlannedUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Status")]
    protected Enumeration<ContainerStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_CurrentThruputQty2")]
    protected Primitive<double> _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_QtyOperator")]
    protected Enumeration<QtyOperatorEnum, int> _QtyOperator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_LastActivityDate")]
    protected Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ProjectedDate")]
    protected Primitive<DateTime> _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_InProcess")]
    protected Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ContainerComments")]
    protected Primitive<string> _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PriorityCode")]
    protected NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_StepName")]
    protected Primitive<string> _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_WorkflowIsRevOfRcd")]
    protected Primitive<bool> _WorkflowIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ProductIsRevOfRcd")]
    protected Primitive<bool> _ProductIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_SpecIsRevOfRcd")]
    protected Primitive<bool> _SpecIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ContainerLevel")]
    protected NamedObjectRef _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Specification")]
    protected Primitive<string> _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ContainerLevelName")]
    protected Primitive<string> _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_NextOperation")]
    protected Primitive<string> _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_SpecRevision")]
    protected Primitive<string> _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_CurrentThruputQty")]
    protected Primitive<double> _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_StatusName")]
    protected Primitive<string> _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_WorkflowRev")]
    protected Primitive<string> _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_PlannedQty")]
    protected Primitive<double> _PlannedQty;

    public override bool Equals(object obj)
    {
      return obj is ContainerStatusDetails && object.Equals((object) this._UOM, (object) ((ContainerStatusDetails) obj)._UOM) && (object.Equals((object) this._PlannedQty2, (object) ((ContainerStatusDetails) obj)._PlannedQty2) && object.Equals((object) this._Spec, (object) ((ContainerStatusDetails) obj)._Spec)) && (object.Equals((object) this._UOM2, (object) ((ContainerStatusDetails) obj)._UOM2) && object.Equals((object) this._PlannedUOM, (object) ((ContainerStatusDetails) obj)._PlannedUOM) && (object.Equals((object) this._PlannedUOM2, (object) ((ContainerStatusDetails) obj)._PlannedUOM2) && object.Equals((object) this._Status, (object) ((ContainerStatusDetails) obj)._Status))) && (object.Equals((object) this._StartReason, (object) ((ContainerStatusDetails) obj)._StartReason) && object.Equals((object) this._CurrentThruputQty2, (object) ((ContainerStatusDetails) obj)._CurrentThruputQty2) && (object.Equals((object) this._HoldReason, (object) ((ContainerStatusDetails) obj)._HoldReason) && object.Equals((object) this._Qty2, (object) ((ContainerStatusDetails) obj)._Qty2)) && (object.Equals((object) this._Customer, (object) ((ContainerStatusDetails) obj)._Customer) && object.Equals((object) this._QtyOperator, (object) ((ContainerStatusDetails) obj)._QtyOperator) && (object.Equals((object) this._Container, (object) ((ContainerStatusDetails) obj)._Container) && object.Equals((object) this._LastActivityDate, (object) ((ContainerStatusDetails) obj)._LastActivityDate)))) && (object.Equals((object) this._RequestDate, (object) ((ContainerStatusDetails) obj)._RequestDate) && object.Equals((object) this._LastMoveDate, (object) ((ContainerStatusDetails) obj)._LastMoveDate) && (object.Equals((object) this._OriginalStartDate, (object) ((ContainerStatusDetails) obj)._OriginalStartDate) && object.Equals((object) this._ProjectedDate, (object) ((ContainerStatusDetails) obj)._ProjectedDate)) && (object.Equals((object) this._InProcess, (object) ((ContainerStatusDetails) obj)._InProcess) && object.Equals((object) this._DueDate, (object) ((ContainerStatusDetails) obj)._DueDate) && (object.Equals((object) this._SalesOrder, (object) ((ContainerStatusDetails) obj)._SalesOrder) && object.Equals((object) this._ReworkReason, (object) ((ContainerStatusDetails) obj)._ReworkReason))) && (object.Equals((object) this._ResourceName, (object) ((ContainerStatusDetails) obj)._ResourceName) && object.Equals((object) this._Workflow, (object) ((ContainerStatusDetails) obj)._Workflow) && (object.Equals((object) this._Step, (object) ((ContainerStatusDetails) obj)._Step) && object.Equals((object) this._ProductDescription, (object) ((ContainerStatusDetails) obj)._ProductDescription)) && (object.Equals((object) this._Location, (object) ((ContainerStatusDetails) obj)._Location) && object.Equals((object) this._Owner, (object) ((ContainerStatusDetails) obj)._Owner) && (object.Equals((object) this._ContainerComments, (object) ((ContainerStatusDetails) obj)._ContainerComments) && object.Equals((object) this._PriorityCode, (object) ((ContainerStatusDetails) obj)._PriorityCode))))) && (object.Equals((object) this._Product, (object) ((ContainerStatusDetails) obj)._Product) && object.Equals((object) this._PlannedProduct, (object) ((ContainerStatusDetails) obj)._PlannedProduct) && (object.Equals((object) this._Resource, (object) ((ContainerStatusDetails) obj)._Resource) && object.Equals((object) this._Operation, (object) ((ContainerStatusDetails) obj)._Operation)) && (object.Equals((object) this._StepName, (object) ((ContainerStatusDetails) obj)._StepName) && object.Equals((object) this._WorkflowIsRevOfRcd, (object) ((ContainerStatusDetails) obj)._WorkflowIsRevOfRcd) && (object.Equals((object) this._Factory, (object) ((ContainerStatusDetails) obj)._Factory) && object.Equals((object) this._ProductIsRevOfRcd, (object) ((ContainerStatusDetails) obj)._ProductIsRevOfRcd))) && (object.Equals((object) this._SpecIsRevOfRcd, (object) ((ContainerStatusDetails) obj)._SpecIsRevOfRcd) && object.Equals((object) this._ContainerLevel, (object) ((ContainerStatusDetails) obj)._ContainerLevel) && (object.Equals((object) this._MfgOrder, (object) ((ContainerStatusDetails) obj)._MfgOrder) && object.Equals((object) this._Specification, (object) ((ContainerStatusDetails) obj)._Specification)) && (object.Equals((object) this._ContainerLevelName, (object) ((ContainerStatusDetails) obj)._ContainerLevelName) && object.Equals((object) this._NextOperation, (object) ((ContainerStatusDetails) obj)._NextOperation) && (object.Equals((object) this._OperationName, (object) ((ContainerStatusDetails) obj)._OperationName) && object.Equals((object) this._ContainerName, (object) ((ContainerStatusDetails) obj)._ContainerName)))) && (object.Equals((object) this._SpecRevision, (object) ((ContainerStatusDetails) obj)._SpecRevision) && object.Equals((object) this._Qty, (object) ((ContainerStatusDetails) obj)._Qty) && (object.Equals((object) this._ProductName, (object) ((ContainerStatusDetails) obj)._ProductName) && object.Equals((object) this._CurrentThruputQty, (object) ((ContainerStatusDetails) obj)._CurrentThruputQty)) && (object.Equals((object) this._StatusName, (object) ((ContainerStatusDetails) obj)._StatusName) && object.Equals((object) this._WorkflowRev, (object) ((ContainerStatusDetails) obj)._WorkflowRev) && (object.Equals((object) this._ProductRev, (object) ((ContainerStatusDetails) obj)._ProductRev) && object.Equals((object) this._PlannedQty, (object) ((ContainerStatusDetails) obj)._PlannedQty))))) && base.Equals(obj);
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

    public RevisionedObjectRef Spec
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

    public NamedObjectRef PlannedUOM
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

    public NamedObjectRef PlannedUOM2
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

    public Enumeration<QtyOperatorEnum, int> QtyOperator
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyOperator), (object) value);
      }
      get
      {
        return (Enumeration<QtyOperatorEnum, int>) this.PropertyGet(nameof (QtyOperator));
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

    public Primitive<bool> InProcess
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

    public NamedObjectRef ReworkReason
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

    public Primitive<string> ResourceName
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

    public RevisionedObjectRef Workflow
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

    public NamedSubentityRef Step
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

    public Primitive<string> ProductDescription
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

    public NamedObjectRef PriorityCode
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

    public Primitive<string> StepName
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

    public Primitive<bool> WorkflowIsRevOfRcd
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

    public Primitive<bool> ProductIsRevOfRcd
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

    public Primitive<bool> SpecIsRevOfRcd
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

    public NamedObjectRef ContainerLevel
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

    public Primitive<string> Specification
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

    public Primitive<string> ContainerLevelName
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

    public Primitive<string> NextOperation
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

    public Primitive<string> OperationName
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

    public Primitive<string> ContainerName
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

    public Primitive<string> SpecRevision
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

    public Primitive<string> ProductName
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

    public Primitive<string> StatusName
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

    public Primitive<string> WorkflowRev
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

    public Primitive<string> ProductRev
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
  }
}
