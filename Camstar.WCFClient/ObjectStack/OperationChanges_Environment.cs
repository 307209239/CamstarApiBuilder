// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OperationChanges_Environment
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
  public class OperationChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ShipmentDestinations")]
    [Metadata("A Named Object Group that represents a group of ShipmentDestination which is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestinationGrp", false, false, false, "NamedObjectRef", 1049867, false, false, true, null)]
    protected Environment _ShipmentDestinations;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_DispatchRule")]
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, false, "NamedObjectRef", 1050380, false, false, true, null)]
    protected Environment _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_SchedulingDetail")]
    [Metadata("Allows maintenance of the scheduling details for an operation", "OperationSchedulingDetailChanges", false, false, false, "OperationSchedulingDetailChanges", 1048641, false, false, false, null)]
    protected OperationSchedulingDetailChanges_Environment _SchedulingDetail;
    [Metadata("A User Code Object Group that represents a group of Buy Reasons.", "BuyReasonGroup", false, false, false, "NamedObjectRef", 1049502, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_BuyReasons")]
    protected Environment _BuyReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ComponentDefectReasons")]
    [Metadata("A User Code Object Group that represents a group of Component Defect Reasons.", "ComponentDefectReasonGroup", false, false, false, "NamedObjectRef", 1049487, false, false, true, null)]
    protected Environment _ComponentDefectReasons;
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_PrintQueue")]
    protected Environment _PrintQueue;
    [Metadata("A User Code Object Group that represents a group of Sell Reasons.", "SellReasonGroup", false, false, false, "NamedObjectRef", 1049506, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_SellReasons")]
    protected Environment _SellReasons;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [Metadata("URL", "", false, false, false, "String", 1050307, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_Image")]
    protected Environment _Image;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_QtyAdjustReasons")]
    [Metadata("A User Code Object Group that represents a group of Quantity Adjust Reasons.", "QtyAdjustReasonGroup", false, false, false, "NamedObjectRef", 1049653, false, false, true, null)]
    protected Environment _QtyAdjustReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_DefaultRollupReason")]
    [Metadata("The user code for rollup reason.", "RollupReason", false, false, false, "NamedObjectRef", 1049623, false, false, true, null)]
    protected Environment _DefaultRollupReason;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ShippingReasons")]
    [Metadata("A User Code Object Group that represents a group of Shipping Reasons.", "ShippingReasonGroup", false, false, false, "NamedObjectRef", 1048986, false, false, true, null)]
    protected Environment _ShippingReasons;
    [Metadata("A User Code Object Group that represents a group of Container Defect Reasons.", "ContainerDefectReasonGroup", false, false, false, "NamedObjectRef", 1049486, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ContainerDefectReasons")]
    protected Environment _ContainerDefectReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_LocalReworkReasons")]
    [Metadata("A User Code Object Group that represents a group of Local Rework Reasons.", "LocalReworkReasonGroup", false, false, false, "NamedObjectRef", 1048638, false, false, true, null)]
    protected Environment _LocalReworkReasons;
    [Metadata("Changes CDO for DisallowedTxns.", "DisallowedTxnsChanges", false, false, false, "DisallowedTxnsChanges", 1048597, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_DisallowedTxns")]
    protected DisallowedTxnsChanges_Environment _DisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [Metadata("Changes CDO for DisallowedTxns.", "DisallowedTxnsChanges", false, false, false, "DisallowedTxnsChanges", 1049323, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_DisallowedTxnItem")]
    protected DisallowedTxnsChanges_Environment _DisallowedTxnItem;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ReworkReasons")]
    [Metadata("A User Code Object Group that represents a group of ReworkReasons.", "ReworkReasonGroup", false, false, false, "NamedObjectRef", 1048640, false, false, true, null)]
    protected Environment _ReworkReasons;
    [Metadata("A User Code Object Group that represents a group of LossReasons.", "LossReasonGroup", false, false, false, "NamedObjectRef", 1048639, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_LossReasons")]
    protected Environment _LossReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_BonusReasons")]
    [Metadata("A User Code Object Group that represents a group of Bonus Reasons.", "BonusReasonGroup", false, false, false, "NamedObjectRef", 1048635, false, false, true, null)]
    protected Environment _BonusReasons;
    [Metadata("Actions menus are used to create set of items linked to UIVirtualPages.", "ActionsMenu", false, false, false, "NamedObjectRef", 1052557, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ActionsMenu")]
    protected Environment _ActionsMenu;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048980, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_OutsideServicePoint")]
    protected Environment _OutsideServicePoint;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048598, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_UseQueue")]
    protected Environment _UseQueue;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_RejectIncomingNCContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050399, false, false, false, "0")]
    protected Environment _RejectIncomingNCContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048987, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_SummaryThruput")]
    protected Environment _SummaryThruput;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048588, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_InventoryPoint")]
    protected Environment _InventoryPoint;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048979, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_InTransit")]
    protected Environment _InTransit;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ThruputReportingLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, true, false, "NamedObjectRef", 1048988, false, false, true, null)]
    protected Environment _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_ObjectToChange")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_WorkCenter")]
    protected Environment _WorkCenter;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049568, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_AutoAdjustReason")]
    [Metadata("An ObjectGroup is used to provide a list of objects, such as a list of Resources, Products or User Codes of a particular type. These lists are typically used for validation and selection. For example, an Operation includes a reference to a LossCodeGroup. The entries in this list define the valid Loss (reason) Codes for work performed while a Container is at that Operation.\r\n\r\nAn instance of an ObjectGroup includes a list of specific objects and a list of ObjectGroups. This list of objects for any given ObjectGroup is restricted to a specific type (or any of its derived types). Likewise, the list of ObjectGroup s within the ObjectGroup is restricted to the same type (or any of its derived types).\r\n", "ObjectGroup", false, false, false, "NamedObjectRef", 1048977, false, false, false, null)]
    protected Environment _AutoAdjustReason;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048976, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Environment_AutoAdjustLimit")]
    protected Environment _AutoAdjustLimit;

    public Environment ShipmentDestinations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestinations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShipmentDestinations));
      }
    }

    public Environment DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public OperationSchedulingDetailChanges_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (OperationSchedulingDetailChanges_Environment) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Environment BuyReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuyReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BuyReasons));
      }
    }

    public Environment ComponentDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComponentDefectReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ComponentDefectReasons));
      }
    }

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment SellReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (SellReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SellReasons));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Environment Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Image));
      }
    }

    public Environment QtyAdjustReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdjustReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyAdjustReasons));
      }
    }

    public Environment DefaultRollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultRollupReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultRollupReason));
      }
    }

    public Environment ShippingReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShippingReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShippingReasons));
      }
    }

    public Environment ContainerDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerDefectReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerDefectReasons));
      }
    }

    public Environment LocalReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LocalReworkReasons));
      }
    }

    public DisallowedTxnsChanges_Environment DisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxns), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges_Environment) this.PropertyGet(nameof (DisallowedTxns));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public DisallowedTxnsChanges_Environment DisallowedTxnItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxnItem), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges_Environment) this.PropertyGet(nameof (DisallowedTxnItem));
      }
    }

    public Environment ReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkReasons));
      }
    }

    public Environment LossReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LossReasons));
      }
    }

    public Environment BonusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BonusReasons));
      }
    }

    public Environment ActionsMenu
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenu), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionsMenu));
      }
    }

    public Environment OutsideServicePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutsideServicePoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OutsideServicePoint));
      }
    }

    public Environment UseQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseQueue));
      }
    }

    public Environment RejectIncomingNCContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectIncomingNCContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RejectIncomingNCContainer));
      }
    }

    public Environment SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Environment InventoryPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InventoryPoint));
      }
    }

    public Environment InTransit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InTransit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InTransit));
      }
    }

    public Environment ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment AutoAdjustReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoAdjustReason));
      }
    }

    public Environment AutoAdjustLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoAdjustLimit));
      }
    }
  }
}
