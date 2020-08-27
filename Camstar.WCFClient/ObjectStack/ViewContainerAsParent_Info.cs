// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerAsParent_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CurrentContainerStatus_Info))]
  [Serializable]
  public class ViewContainerAsParent_Info : ContainerStatusDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PlannedUOM")]
    protected new Info _PlannedUOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Customer")]
    protected new Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PlannedUOM2")]
    protected new Info _PlannedUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PlannedQty2")]
    protected new Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_HoldReason")]
    protected new Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_CurrentThruputQty2")]
    protected new Info _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_UOM2")]
    protected new Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ContainerStatus")]
    protected Info _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_OriginalStartDate")]
    protected new Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_LastMoveDate")]
    protected new Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_LastActivityDate")]
    protected new Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ProjectedDate")]
    protected new Info _ProjectedDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_DueDate")]
    protected new Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_RequestDate")]
    protected new Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_InProcess")]
    protected new Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Step")]
    protected new Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_HoldReasonName")]
    protected Info _HoldReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ProductName")]
    protected new Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ContainerLevelName")]
    protected new Info _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Operation")]
    protected new Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_CurrentThruputQty")]
    protected new Info _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_StatusName")]
    protected new Info _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ProductDescription")]
    protected new Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ResourceName")]
    protected new Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Resource")]
    protected new Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ReworkReason")]
    protected new Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Location")]
    protected new Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_DocumentEntries")]
    protected DocumentEntry_Info _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_WorkflowRev")]
    protected new Info _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_StartReasonName")]
    protected Info _StartReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PlannedQty")]
    protected new Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ProductRev")]
    protected new Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PriorityCode")]
    protected new Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_SalesOrderName")]
    protected Info _SalesOrderName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ContainerLevel")]
    protected new Info _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_WorkflowIsRevOfRcd")]
    protected new Info _WorkflowIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_StepName")]
    protected new Info _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_MfgOrderName")]
    protected Info _MfgOrderName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Specification")]
    protected new Info _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ProductIsRevOfRcd")]
    protected new Info _ProductIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PriorityCodeName")]
    protected Info _PriorityCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_UOM2Name")]
    protected Info _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_SpecRevision")]
    protected new Info _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_ContainerComments")]
    protected new Info _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_SalesOrder")]
    protected new Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_PlannedProduct")]
    protected new Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_OwnerName")]
    protected Info _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_NextOperation")]
    protected new Info _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_SpecIsRevOfRcd")]
    protected new Info _SpecIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_Workflow")]
    protected new Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_CustomerName")]
    protected Info _CustomerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_LocationName")]
    protected Info _LocationName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Info_OperationName")]
    protected new Info _OperationName;

    public new Info PlannedUOM
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

    public new Info PlannedUOM2
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

    public new Info PlannedQty2
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

    public new Info CurrentThruputQty2
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

    public new Info Qty2
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

    public new Info UOM2
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

    public Info ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public new Info OriginalStartDate
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

    public new Info LastMoveDate
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

    public new Info LastActivityDate
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

    public new Info ProjectedDate
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

    public new Info RequestDate
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

    public Info HoldReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReasonName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReasonName));
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

    public new Info CurrentThruputQty
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

    public new Info StatusName
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

    public new Info ProductDescription
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

    public DocumentEntry_Info DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Info) this.PropertyGet(nameof (DocumentEntries));
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

    public Info StartReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReasonName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReasonName));
      }
    }

    public new Info PlannedQty
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

    public Info SalesOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrderName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SalesOrderName));
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

    public new Info WorkflowIsRevOfRcd
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

    public Info MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrderName));
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

    public new Info ProductIsRevOfRcd
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

    public Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }

    public Info PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public Info UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2Name));
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

    public new Info ContainerComments
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

    public new Info PlannedProduct
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

    public Info OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerName));
      }
    }

    public new Info NextOperation
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

    public new Info SpecIsRevOfRcd
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

    public Info CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerName));
      }
    }

    public Info LocationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LocationName));
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
  }
}
