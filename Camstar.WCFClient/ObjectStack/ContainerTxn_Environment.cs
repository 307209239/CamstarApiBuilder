// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxn_Environment
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
  public class ContainerTxn_Environment : ShopFloor_Environment
  {
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1052669, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_CalledByTransactionTask")]
    protected new Environment _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, true, "NamedObjectRef", 1050380, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_DispatchRule")]
    protected new Environment _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_CurrentContainerStatus")]
    [Metadata("Current status information of a Container", "CurrentContainerStatus", false, false, true, "CurrentContainerStatus", 1050388, true, false, false, null)]
    protected CurrentContainerStatus_Environment _CurrentContainerStatus;
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_WIPMsgMgr")]
    protected new WIPMsgMgr_Environment _WIPMsgMgr;
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1049935, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_MfgCalendar")]
    protected new Environment _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    protected new Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050576, false, false, false, null)]
    protected new Environment _ESigRequirement;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_MfgProcessOverrides")]
    protected new Environment _MfgProcessOverrides;
    [Metadata("The ESigReqDetail used to fulfill all or part of an ESigRequirement for Process Timer", "ESigProcessTimerServiceDetail", false, false, false, "ESigProcessTimerServiceDetail", 16778926, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_ESigProcessTimerDetails")]
    protected ESigProcessTimerServiceDetail_Environment _ESigProcessTimerDetails;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_Carrier")]
    protected Environment _Carrier;
    [Metadata("The Collect Data Points transaction is used to collect data points for a trackable object.  It requires that the trackable object have a DataPointCollection assigned to it.", "CollectDataPoints", false, false, false, "CollectDataPoints", 1052463, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_CollectDataPoints")]
    protected CollectDataPoints_Environment _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_ProcessTimerHistoryDetail")]
    [Metadata("ProcessTimerHistoryDetail", "ProcessTimerHistoryDetail", false, false, false, "SubentityRef", 16778925, false, false, false, null)]
    protected Environment _ProcessTimerHistoryDetail;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_SamplingPlan")]
    protected new Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected new Environment _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_UseQueue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048598, false, false, false, "1")]
    protected Environment _UseQueue;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_IsRemoteService")]
    protected new Environment _IsRemoteService;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778944, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_IsConfirmation")]
    protected Environment _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_UseMfgNCR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052538, false, false, false, "0")]
    protected Environment _UseMfgNCR;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_TaskContainer")]
    protected new Environment _TaskContainer;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_UseDispatch")]
    protected new Environment _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    protected new Environment _MfgOrder;
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Environment_WorkCenter")]
    protected Environment _WorkCenter;

    public new Environment CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public new Environment PrintQueue
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

    public new Environment DispatchRule
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

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public CurrentContainerStatus_Environment CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Environment) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public new WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public new Environment MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public ESigProcessTimerServiceDetail_Environment ESigProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDetails), (object) value);
      }
      get
      {
        return (ESigProcessTimerServiceDetail_Environment) this.PropertyGet(nameof (ESigProcessTimerDetails));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public CollectDataPoints_Environment CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Environment) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public Environment ProcessTimerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerHistoryDetail));
      }
    }

    public new Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
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

    public new Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Environment IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public Environment UseMfgNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMfgNCR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseMfgNCR));
      }
    }

    public new Environment TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public new Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public new Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
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
  }
}
