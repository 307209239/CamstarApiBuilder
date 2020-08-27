// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecChanges_Environment
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
  public class SpecChanges_Environment : BusinessProcessSpecChanges_Environment
  {
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ResourceGroup")]
    protected Environment _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ElectronicProcedure")]
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.  An Electronic Procedure defines a set of instructions (a checklisst for performing a set of tasks), and is compose of one ore more TaskLists.", "ElectronicProcedure", false, false, false, "RevisionedObjectRef", 1050523, false, false, true, null)]
    protected Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_SchedulingDetail")]
    [Metadata("Changes CDO for SpecSchedulingDetail.", "SpecSchedulingDetailChanges", false, false, false, "SpecSchedulingDetailChanges", 1048916, true, false, false, null)]
    protected SpecSchedulingDetailChanges_Environment _SchedulingDetail;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_TxnMapItem")]
    [Metadata("Changes CDO for TxnMap.", "TxnMapChanges", false, false, false, "TxnMapChanges", 1049355, true, false, false, null)]
    protected TxnMapChanges_Environment _TxnMapItem;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_Base")]
    [Metadata("A Specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\n", "SpecBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "BillOfProcess", 1050936, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_BillOfProcessAssignments")]
    protected BillOfProcess_Environment _BillOfProcessAssignments;
    [Metadata("Contains a match between a service and a label definition to be printed.", "ContainerLabelMapChanges", false, false, false, "ContainerLabelMapChanges", 1050618, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_LabelTxnMap")]
    protected ContainerLabelMapChanges_Environment _LabelTxnMap;
    [Metadata("Changes CDO for TxnMap.", "TxnMapChanges", false, false, false, "TxnMapChanges", 1049022, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_TxnMap")]
    protected TxnMapChanges_Environment _TxnMap;
    [Metadata("Transaction map for container services.", "ContainerESigTxnMapChanges", false, false, false, "ContainerESigTxnMapChanges", 1050351, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ESigTxnMap")]
    protected ContainerESigTxnMapChanges_Environment _ESigTxnMap;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_EndTimerTxnMap")]
    [Metadata("EndTimerTxnMapChanges", "EndTimerTxnMapChanges", false, false, false, "EndTimerTxnMapChanges", 16778399, false, true, false, null)]
    protected EndTimerTxnMapChanges_Environment _EndTimerTxnMap;
    [Metadata("StartTimerTxnMapChanges", "StartTimerTxnMapChanges", false, false, false, "StartTimerTxnMapChanges", 16778400, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_StartTimerTxnMap")]
    protected StartTimerTxnMapChanges_Environment _StartTimerTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ValidateLotSamplingComplete")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777725, false, false, false, "0")]
    protected Environment _ValidateLotSamplingComplete;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_AllowOverrides")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050940, false, false, false, "1")]
    protected Environment _AllowOverrides;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_AllowReworkTo")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048714, false, false, false, "0")]
    protected Environment _AllowReworkTo;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_ValidateMaterialConsumption")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050896, false, false, false, "0")]
    protected Environment _ValidateMaterialConsumption;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_Setup")]
    protected Environment _Setup;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048715, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_MaxQueueTime")]
    protected Environment _MaxQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_WarningQueueTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048717, false, false, false, null)]
    protected Environment _WarningQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    protected Environment _DocumentSet;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050232, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_RecipeFile")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048762, false, false, true, null)]
    protected Environment _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_MaxQueueTimeAction")]
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1049021, false, false, false, "0")]
    protected Environment _MaxQueueTimeAction;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, true, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Environment_Operation")]
    protected Environment _Operation;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public SpecSchedulingDetailChanges_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SpecSchedulingDetailChanges_Environment) this.PropertyGet(nameof (SchedulingDetail));
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

    public TxnMapChanges_Environment TxnMapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMapItem), (object) value);
      }
      get
      {
        return (TxnMapChanges_Environment) this.PropertyGet(nameof (TxnMapItem));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public BillOfProcess_Environment BillOfProcessAssignments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessAssignments), (object) value);
      }
      get
      {
        return (BillOfProcess_Environment) this.PropertyGet(nameof (BillOfProcessAssignments));
      }
    }

    public ContainerLabelMapChanges_Environment LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges_Environment) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public TxnMapChanges_Environment TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges_Environment) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerESigTxnMapChanges_Environment ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges_Environment) this.PropertyGet(nameof (ESigTxnMap));
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

    public EndTimerTxnMapChanges_Environment EndTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTxnMap), (object) value);
      }
      get
      {
        return (EndTimerTxnMapChanges_Environment) this.PropertyGet(nameof (EndTimerTxnMap));
      }
    }

    public StartTimerTxnMapChanges_Environment StartTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTxnMap), (object) value);
      }
      get
      {
        return (StartTimerTxnMapChanges_Environment) this.PropertyGet(nameof (StartTimerTxnMap));
      }
    }

    public Environment ValidateLotSamplingComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateLotSamplingComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidateLotSamplingComplete));
      }
    }

    public Environment AllowOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowOverrides));
      }
    }

    public Environment AllowReworkTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReworkTo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowReworkTo));
      }
    }

    public Environment ValidateMaterialConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateMaterialConsumption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidateMaterialConsumption));
      }
    }

    public Environment Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Setup));
      }
    }

    public Environment MaxQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxQueueTime));
      }
    }

    public Environment WarningQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQueueTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WarningQueueTime));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
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

    public Environment RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeFile));
      }
    }

    public Environment MaxQueueTimeAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTimeAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxQueueTimeAction));
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
  }
}
