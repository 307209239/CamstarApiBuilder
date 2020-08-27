// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSearchDetail_Info
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
  public class ContainerSearchDetail_Info : ContainerStatusDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_HoldReason")]
    protected new Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Customer")]
    protected new Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_SpecHistory")]
    protected Info _SpecHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_QtyOperator")]
    protected new Info _QtyOperator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_InProcessFilter")]
    protected Info _InProcessFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_OnHoldFilter")]
    protected Info _OnHoldFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_InReworkFilter")]
    protected Info _InReworkFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_DueDate")]
    protected new Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_InQualityControl")]
    protected Info _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_TxnFromDate")]
    protected Info _TxnFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_TxnToDate")]
    protected Info _TxnToDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_OpenNonConformances")]
    protected Info _OpenNonConformances;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_InProcess")]
    protected new Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_OnHold")]
    protected Info _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ApplyLineAssignmentHistory")]
    protected Info _ApplyLineAssignmentHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_FromIssuedStockPoint")]
    protected Info _FromIssuedStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_FromIssuedLot")]
    protected Info _FromIssuedLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_InRework")]
    protected Info _InRework;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ApplyLineAssignmentCurrentStatus")]
    protected Info _ApplyLineAssignmentCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_IssuedComponentProduct")]
    protected Info _IssuedComponentProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Operation")]
    protected new Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_OperationHistory")]
    protected Info _OperationHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_SpecRevision")]
    protected new Info _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_SalesOrder")]
    protected new Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Step")]
    protected new Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_LAResource")]
    protected Info _LAResource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_LAWorkstation")]
    protected Info _LAWorkstation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ResourceName")]
    protected new Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_IssuedContainer")]
    protected Info _IssuedContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ProductRev")]
    protected new Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_OperationName")]
    protected new Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Workflow")]
    protected new Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Specification")]
    protected new Info _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ReworkReason")]
    protected new Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_LAOperation")]
    protected Info _LAOperation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_HistoryEmployeeHistory")]
    protected Info _HistoryEmployeeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Resource")]
    protected new Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ContainerLevelName")]
    protected new Info _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ResourceHistory")]
    protected Info _ResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_StepName")]
    protected new Info _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ContainerLevel")]
    protected new Info _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_LAWorkCenter")]
    protected Info _LAWorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_ProductName")]
    protected new Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_Location")]
    protected new Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_PriorityCode")]
    protected new Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Info_WorkflowRev")]
    protected new Info _WorkflowRev;

    public new Info UOM
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

    public new Info HoldReason
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

    public new Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info Customer
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

    public new Info StartReason
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

    public new Info Status
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

    public Info SpecHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecHistory));
      }
    }

    public new Info QtyOperator
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyOperator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyOperator));
      }
    }

    public Info InProcessFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcessFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InProcessFilter));
      }
    }

    public Info OnHoldFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHoldFilter));
      }
    }

    public Info InReworkFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InReworkFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InReworkFilter));
      }
    }

    public new Info DueDate
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

    public Info TxnFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnFromDate));
      }
    }

    public Info TxnToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnToDate));
      }
    }

    public Info OpenNonConformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonConformances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OpenNonConformances));
      }
    }

    public new Info InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InProcess));
      }
    }

    public Info OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHold));
      }
    }

    public Info ApplyLineAssignmentHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApplyLineAssignmentHistory));
      }
    }

    public Info FromIssuedStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromIssuedStockPoint));
      }
    }

    public Info FromIssuedLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromIssuedLot));
      }
    }

    public Info InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InRework));
      }
    }

    public Info ApplyLineAssignmentCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentCurrentStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApplyLineAssignmentCurrentStatus));
      }
    }

    public new Info Container
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

    public Info IssuedComponentProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedComponentProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedComponentProduct));
      }
    }

    public new Info Operation
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

    public Info OperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationHistory));
      }
    }

    public new Info SpecRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecRevision));
      }
    }

    public new Info Owner
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

    public new Info SalesOrder
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

    public new Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
      }
    }

    public Info LAResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAResource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LAResource));
      }
    }

    public Info LAWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LAWorkstation));
      }
    }

    public new Info MfgOrder
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

    public new Info ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceName));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info IssuedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedContainer));
      }
    }

    public new Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }

    public new Info OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationName));
      }
    }

    public new Info Qty
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

    public new Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public new Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new Info Specification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Specification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Specification));
      }
    }

    public new Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Info LAOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAOperation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LAOperation));
      }
    }

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Info HistoryEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryEmployeeHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryEmployeeHistory));
      }
    }

    public new Info Resource
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

    public new Info ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevelName));
      }
    }

    public Info ResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceHistory));
      }
    }

    public new Info StepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepName));
      }
    }

    public new Info ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new Info Product
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

    public Info LAWorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LAWorkCenter));
      }
    }

    public new Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Info Location
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

    public new Info PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new Info WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowRev));
      }
    }
  }
}
