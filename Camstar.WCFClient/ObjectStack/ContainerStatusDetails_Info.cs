// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerSearchDetail_Info))]
  [KnownType(typeof (ChangeAttributeAsParent_Info))]
  [KnownType(typeof (ViewContainerAsParent_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerStatusDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PlannedQty2")]
    protected Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PlannedUOM")]
    protected Info _PlannedUOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PlannedUOM2")]
    protected Info _PlannedUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_StartReason")]
    protected Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_CurrentThruputQty2")]
    protected Info _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_QtyOperator")]
    protected Info _QtyOperator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_LastActivityDate")]
    protected Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_RequestDate")]
    protected Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_OriginalStartDate")]
    protected Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ProjectedDate")]
    protected Info _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_InProcess")]
    protected Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_SalesOrder")]
    protected Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ResourceName")]
    protected Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ContainerComments")]
    protected Info _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PriorityCode")]
    protected Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PlannedProduct")]
    protected Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_StepName")]
    protected Info _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_WorkflowIsRevOfRcd")]
    protected Info _WorkflowIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ProductIsRevOfRcd")]
    protected Info _ProductIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_SpecIsRevOfRcd")]
    protected Info _SpecIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ContainerLevel")]
    protected Info _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_MfgOrder")]
    protected Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Specification")]
    protected Info _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ContainerLevelName")]
    protected Info _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_NextOperation")]
    protected Info _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ContainerName")]
    protected Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_SpecRevision")]
    protected Info _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_CurrentThruputQty")]
    protected Info _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_StatusName")]
    protected Info _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_WorkflowRev")]
    protected Info _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusDetails_Info_PlannedQty")]
    protected Info _PlannedQty;

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

    public Info Spec
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

    public Info PlannedUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedUOM));
      }
    }

    public Info PlannedUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedUOM2));
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

    public Info QtyOperator
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

    public Info Container
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

    public Info InProcess
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

    public Info ReworkReason
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

    public Info ResourceName
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

    public Info Workflow
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

    public Info Step
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

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info Location
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

    public Info PriorityCode
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

    public Info Resource
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

    public Info Operation
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

    public Info StepName
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

    public Info WorkflowIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowIsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowIsRevOfRcd));
      }
    }

    public Info Factory
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

    public Info ProductIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductIsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductIsRevOfRcd));
      }
    }

    public Info SpecIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecIsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecIsRevOfRcd));
      }
    }

    public Info ContainerLevel
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

    public Info Specification
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

    public Info ContainerLevelName
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

    public Info NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextOperation));
      }
    }

    public Info OperationName
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

    public Info ContainerName
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

    public Info SpecRevision
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

    public Info ProductName
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

    public Info StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusName));
      }
    }

    public Info WorkflowRev
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

    public Info ProductRev
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
  }
}
