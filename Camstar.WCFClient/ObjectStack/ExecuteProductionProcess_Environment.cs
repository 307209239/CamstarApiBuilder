// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteProductionProcess_Environment
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
  public class ExecuteProductionProcess_Environment : ContainerTxn_Environment
  {
    [Metadata("Instruction", "", false, false, true, "String", 1050514, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Instruction")]
    protected Environment _Instruction;
    [Metadata("Enumeration for TaskType.\r\n1 = Start Process Task\r\n2 = End Process Task\r\n3 = Regular Process Task", "TaskTypeEnum", false, false, true, "Integer", 1050512, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_TaskType")]
    protected Environment _TaskType;
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_CalledByTransactionTask")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1052669, false, false, false, null)]
    protected new Environment _CalledByTransactionTask;
    [Metadata("Enumeration for the InstructionType.\r\n1 = Pass/Fail\r\n2 = Data Collection\r\n3 = Acknowledgement", "InstructionTypeEnum", false, false, true, "Integer", 1050525, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_InstructionType")]
    protected Environment _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_TaskComments")]
    [Metadata("Comments", "", false, false, false, "String", 1050548, false, false, false, null)]
    protected Environment _TaskComments;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, true, "NamedObjectRef", 1050473, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050549, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_PrerequisiteTasks")]
    protected Environment _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    protected new Environment _Carrier;
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcess", false, false, true, "RevisionedObjectRef", 1051889, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_ElectronicProcedure")]
    protected Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_TaskList")]
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, true, false, "RevisionedObjectRef", 1051890, false, false, false, null)]
    protected Environment _TaskList;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, true, false, "NamedSubentityRef", 1051870, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Task")]
    protected Environment _Task;
    [Metadata("Encapsulates TaskList/Task validation logic as it relates to sequence of Tasks/TaskList completion.", "ProcessSequenceValidation", false, false, true, "ProcessSequenceValidation", 1052217, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_ProcessSequenceValidation")]
    protected ProcessSequenceValidation_Environment _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_ProcessListDetails")]
    [Metadata("This object will be populated with ProcessList data for a specific container to be used in an inquiry.", "ProcessListDetail", false, false, false, "ProcessListDetail", 1052663, false, true, false, null)]
    protected ProcessListDetail_Environment _ProcessListDetails;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Container")]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Pass")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050894, false, false, true, "1")]
    protected Environment _Pass;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778944, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_IsConfirmation")]
    protected new Environment _IsConfirmation;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_TaskContainer")]
    protected new Environment _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_UseDispatch")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "1")]
    protected new Environment _UseDispatch;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1048646, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050547, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_WorkCell")]
    protected Environment _WorkCell;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_DerivedWorkstation")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050551, false, false, false, null)]
    protected Environment _DerivedWorkstation;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050517, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_Workstation")]
    protected Environment _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_DocumentEntries")]
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, true, "DocumentEntry", 1050452, false, true, false, null)]
    protected DocumentEntry_Environment _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Environment_ParametricDataDef")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049436, false, false, true, null)]
    protected Environment _ParametricDataDef;

    public Environment Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instruction));
      }
    }

    public Environment TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskType));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

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

    public Environment InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstructionType));
      }
    }

    public Environment TaskComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskComments));
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

    public Environment PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new Environment Carrier
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

    public Environment TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskList));
      }
    }

    public Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
      }
    }

    public ProcessSequenceValidation_Environment ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (ProcessSequenceValidation_Environment) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public ProcessListDetail_Environment ProcessListDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessListDetails), (object) value);
      }
      get
      {
        return (ProcessListDetail_Environment) this.PropertyGet(nameof (ProcessListDetails));
      }
    }

    public new Environment Container
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

    public Environment Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Pass));
      }
    }

    public new Environment IsConfirmation
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

    public Environment WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCell));
      }
    }

    public Environment DerivedWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedWorkstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DerivedWorkstation));
      }
    }

    public Environment Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workstation));
      }
    }

    public DocumentEntry_Environment DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Environment) this.PropertyGet(nameof (DocumentEntries));
      }
    }

    public Environment ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
