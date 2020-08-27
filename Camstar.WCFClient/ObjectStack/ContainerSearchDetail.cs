// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSearchDetail
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
  public class ContainerSearchDetail : ContainerStatusDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_HoldReason")]
    protected new NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Customer")]
    protected new NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Status")]
    protected new Enumeration<ContainerStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_SpecHistory")]
    protected RevisionedObjectRef _SpecHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_QtyOperator")]
    protected new Enumeration<QtyOperatorEnum, int> _QtyOperator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_InProcessFilter")]
    protected Enumeration<ContainerSearchFilterEnum, int> _InProcessFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_OnHoldFilter")]
    protected Enumeration<ContainerSearchFilterEnum, int> _OnHoldFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_InReworkFilter")]
    protected Enumeration<ContainerSearchFilterEnum, int> _InReworkFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_DueDate")]
    protected new Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_InQualityControl")]
    protected Primitive<bool> _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_TxnFromDate")]
    protected Primitive<DateTime> _TxnFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_TxnToDate")]
    protected Primitive<DateTime> _TxnToDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_OpenNonConformances")]
    protected Primitive<bool> _OpenNonConformances;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_InProcess")]
    protected new Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_OnHold")]
    protected Primitive<bool> _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ApplyLineAssignmentHistory")]
    protected Primitive<bool> _ApplyLineAssignmentHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_FromIssuedStockPoint")]
    protected Primitive<string> _FromIssuedStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_FromIssuedLot")]
    protected Primitive<string> _FromIssuedLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_InRework")]
    protected Primitive<bool> _InRework;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ApplyLineAssignmentCurrentStatus")]
    protected Primitive<bool> _ApplyLineAssignmentCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_IssuedComponentProduct")]
    protected RevisionedObjectRef _IssuedComponentProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Operation")]
    protected new NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_OperationHistory")]
    protected NamedObjectRef _OperationHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_SpecRevision")]
    protected new Primitive<string> _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_SalesOrder")]
    protected new NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Step")]
    protected new NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_LAResource")]
    protected NamedObjectRef _LAResource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_LAWorkstation")]
    protected NamedObjectRef _LAWorkstation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ResourceName")]
    protected new Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_IssuedContainer")]
    protected Primitive<string> _IssuedContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ProductRev")]
    protected new Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_OperationName")]
    protected new Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Specification")]
    protected new Primitive<string> _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ReworkReason")]
    protected new NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_LAOperation")]
    protected NamedObjectRef _LAOperation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_HistoryEmployeeHistory")]
    protected NamedObjectRef _HistoryEmployeeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ContainerLevelName")]
    protected new Primitive<string> _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ResourceHistory")]
    protected NamedObjectRef _ResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_StepName")]
    protected new Primitive<string> _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ContainerLevel")]
    protected new NamedObjectRef _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_LAWorkCenter")]
    protected NamedObjectRef _LAWorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_ProductName")]
    protected new Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Location")]
    protected new NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_PriorityCode")]
    protected new NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_WorkflowRev")]
    protected new Primitive<string> _WorkflowRev;

    public override bool Equals(object obj)
    {
      return obj is ContainerSearchDetail && object.Equals((object) this._UOM, (object) ((ContainerSearchDetail) obj)._UOM) && (object.Equals((object) this._HoldReason, (object) ((ContainerSearchDetail) obj)._HoldReason) && object.Equals((object) this._Spec, (object) ((ContainerSearchDetail) obj)._Spec)) && (object.Equals((object) this._Customer, (object) ((ContainerSearchDetail) obj)._Customer) && object.Equals((object) this._StartReason, (object) ((ContainerSearchDetail) obj)._StartReason) && (object.Equals((object) this._Status, (object) ((ContainerSearchDetail) obj)._Status) && object.Equals((object) this._SpecHistory, (object) ((ContainerSearchDetail) obj)._SpecHistory))) && (object.Equals((object) this._QtyOperator, (object) ((ContainerSearchDetail) obj)._QtyOperator) && object.Equals((object) this._InProcessFilter, (object) ((ContainerSearchDetail) obj)._InProcessFilter) && (object.Equals((object) this._OnHoldFilter, (object) ((ContainerSearchDetail) obj)._OnHoldFilter) && object.Equals((object) this._InReworkFilter, (object) ((ContainerSearchDetail) obj)._InReworkFilter)) && (object.Equals((object) this._DueDate, (object) ((ContainerSearchDetail) obj)._DueDate) && object.Equals((object) this._InQualityControl, (object) ((ContainerSearchDetail) obj)._InQualityControl) && (object.Equals((object) this._TxnFromDate, (object) ((ContainerSearchDetail) obj)._TxnFromDate) && object.Equals((object) this._TxnToDate, (object) ((ContainerSearchDetail) obj)._TxnToDate)))) && (object.Equals((object) this._OpenNonConformances, (object) ((ContainerSearchDetail) obj)._OpenNonConformances) && object.Equals((object) this._InProcess, (object) ((ContainerSearchDetail) obj)._InProcess) && (object.Equals((object) this._OnHold, (object) ((ContainerSearchDetail) obj)._OnHold) && object.Equals((object) this._ApplyLineAssignmentHistory, (object) ((ContainerSearchDetail) obj)._ApplyLineAssignmentHistory)) && (object.Equals((object) this._FromIssuedStockPoint, (object) ((ContainerSearchDetail) obj)._FromIssuedStockPoint) && object.Equals((object) this._FromIssuedLot, (object) ((ContainerSearchDetail) obj)._FromIssuedLot) && (object.Equals((object) this._InRework, (object) ((ContainerSearchDetail) obj)._InRework) && object.Equals((object) this._ApplyLineAssignmentCurrentStatus, (object) ((ContainerSearchDetail) obj)._ApplyLineAssignmentCurrentStatus))) && (object.Equals((object) this._Container, (object) ((ContainerSearchDetail) obj)._Container) && object.Equals((object) this._IssuedComponentProduct, (object) ((ContainerSearchDetail) obj)._IssuedComponentProduct) && (object.Equals((object) this._Operation, (object) ((ContainerSearchDetail) obj)._Operation) && object.Equals((object) this._OperationHistory, (object) ((ContainerSearchDetail) obj)._OperationHistory)) && (object.Equals((object) this._SpecRevision, (object) ((ContainerSearchDetail) obj)._SpecRevision) && object.Equals((object) this._Owner, (object) ((ContainerSearchDetail) obj)._Owner) && (object.Equals((object) this._Workstation, (object) ((ContainerSearchDetail) obj)._Workstation) && object.Equals((object) this._SalesOrder, (object) ((ContainerSearchDetail) obj)._SalesOrder))))) && (object.Equals((object) this._Step, (object) ((ContainerSearchDetail) obj)._Step) && object.Equals((object) this._LAResource, (object) ((ContainerSearchDetail) obj)._LAResource) && (object.Equals((object) this._LAWorkstation, (object) ((ContainerSearchDetail) obj)._LAWorkstation) && object.Equals((object) this._MfgOrder, (object) ((ContainerSearchDetail) obj)._MfgOrder)) && (object.Equals((object) this._ResourceName, (object) ((ContainerSearchDetail) obj)._ResourceName) && object.Equals((object) this._Factory, (object) ((ContainerSearchDetail) obj)._Factory) && (object.Equals((object) this._IssuedContainer, (object) ((ContainerSearchDetail) obj)._IssuedContainer) && object.Equals((object) this._ProductRev, (object) ((ContainerSearchDetail) obj)._ProductRev))) && (object.Equals((object) this._OperationName, (object) ((ContainerSearchDetail) obj)._OperationName) && object.Equals((object) this._Qty, (object) ((ContainerSearchDetail) obj)._Qty) && (object.Equals((object) this._Workflow, (object) ((ContainerSearchDetail) obj)._Workflow) && object.Equals((object) this._ContainerName, (object) ((ContainerSearchDetail) obj)._ContainerName)) && (object.Equals((object) this._Specification, (object) ((ContainerSearchDetail) obj)._Specification) && object.Equals((object) this._ReworkReason, (object) ((ContainerSearchDetail) obj)._ReworkReason) && (object.Equals((object) this._LAOperation, (object) ((ContainerSearchDetail) obj)._LAOperation) && object.Equals((object) this._WorkCenter, (object) ((ContainerSearchDetail) obj)._WorkCenter)))) && (object.Equals((object) this._HistoryEmployeeHistory, (object) ((ContainerSearchDetail) obj)._HistoryEmployeeHistory) && object.Equals((object) this._Resource, (object) ((ContainerSearchDetail) obj)._Resource) && (object.Equals((object) this._ContainerLevelName, (object) ((ContainerSearchDetail) obj)._ContainerLevelName) && object.Equals((object) this._ResourceHistory, (object) ((ContainerSearchDetail) obj)._ResourceHistory)) && (object.Equals((object) this._StepName, (object) ((ContainerSearchDetail) obj)._StepName) && object.Equals((object) this._ContainerLevel, (object) ((ContainerSearchDetail) obj)._ContainerLevel) && (object.Equals((object) this._Product, (object) ((ContainerSearchDetail) obj)._Product) && object.Equals((object) this._LAWorkCenter, (object) ((ContainerSearchDetail) obj)._LAWorkCenter))) && (object.Equals((object) this._ProductName, (object) ((ContainerSearchDetail) obj)._ProductName) && object.Equals((object) this._Location, (object) ((ContainerSearchDetail) obj)._Location) && (object.Equals((object) this._PriorityCode, (object) ((ContainerSearchDetail) obj)._PriorityCode) && object.Equals((object) this._WorkflowRev, (object) ((ContainerSearchDetail) obj)._WorkflowRev))))) && base.Equals(obj);
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

    public RevisionedObjectRef SpecHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecHistory), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SpecHistory));
      }
    }

    public new Enumeration<QtyOperatorEnum, int> QtyOperator
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

    public Enumeration<ContainerSearchFilterEnum, int> InProcessFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcessFilter), (object) value);
      }
      get
      {
        return (Enumeration<ContainerSearchFilterEnum, int>) this.PropertyGet(nameof (InProcessFilter));
      }
    }

    public Enumeration<ContainerSearchFilterEnum, int> OnHoldFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldFilter), (object) value);
      }
      get
      {
        return (Enumeration<ContainerSearchFilterEnum, int>) this.PropertyGet(nameof (OnHoldFilter));
      }
    }

    public Enumeration<ContainerSearchFilterEnum, int> InReworkFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InReworkFilter), (object) value);
      }
      get
      {
        return (Enumeration<ContainerSearchFilterEnum, int>) this.PropertyGet(nameof (InReworkFilter));
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

    public Primitive<bool> InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InQualityControl));
      }
    }

    public Primitive<DateTime> TxnFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnFromDate));
      }
    }

    public Primitive<DateTime> TxnToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnToDate));
      }
    }

    public Primitive<bool> OpenNonConformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonConformances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OpenNonConformances));
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

    public Primitive<bool> OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnHold));
      }
    }

    public Primitive<bool> ApplyLineAssignmentHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApplyLineAssignmentHistory));
      }
    }

    public Primitive<string> FromIssuedStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromIssuedStockPoint));
      }
    }

    public Primitive<string> FromIssuedLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromIssuedLot));
      }
    }

    public Primitive<bool> InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InRework));
      }
    }

    public Primitive<bool> ApplyLineAssignmentCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentCurrentStatus), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApplyLineAssignmentCurrentStatus));
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

    public RevisionedObjectRef IssuedComponentProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedComponentProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (IssuedComponentProduct));
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

    public NamedObjectRef OperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationHistory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OperationHistory));
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

    public NamedObjectRef LAResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LAResource));
      }
    }

    public NamedObjectRef LAWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LAWorkstation));
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

    public Primitive<string> IssuedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedContainer), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedContainer));
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

    public NamedObjectRef LAOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAOperation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LAOperation));
      }
    }

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public NamedObjectRef HistoryEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryEmployeeHistory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HistoryEmployeeHistory));
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

    public NamedObjectRef ResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceHistory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceHistory));
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

    public NamedObjectRef LAWorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LAWorkCenter));
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
  }
}
