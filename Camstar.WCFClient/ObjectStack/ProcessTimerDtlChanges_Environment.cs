// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerDtlChanges_Environment
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
  public class ProcessTimerDtlChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_DefaultFailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1053128, false, false, true, null)]
    protected Environment _DefaultFailureMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [Metadata("Instruction", "", false, false, false, "String", 1053129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_DefaultPEDescription")]
    protected Environment _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ToWorkflowStack")]
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1049818, false, true, true, null)]
    protected Environment _ToWorkflowStack;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_HoldReason")]
    protected Environment _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050352, false, false, true, null)]
    protected Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ObjectToChange")]
    [Metadata("ProcessTimerDtl", "ProcessTimerDtl", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _SubClassification;
    [Metadata("Enumeration for TimerActionEnum\r\n1 = EndTxnNotExecute\r\n2 = EndTxnExecute", "TimerActionEnum", false, false, false, "Integer", 16778373, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_TimerAction")]
    protected Environment _TimerAction;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_Classification")]
    protected Environment _Classification;
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1051287, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_BusinessRule")]
    protected Environment _BusinessRule;
    [Metadata("ProcessTimerDtlChanges", "ProcessTimerDtlChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsConfirmation")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778771, false, false, false, "0")]
    protected Environment _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsBusinessRule")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778750, false, false, false, "0")]
    protected Environment _IsBusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsProductionEvent")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778382, false, false, false, "0")]
    protected Environment _IsProductionEvent;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778383, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsRework")]
    protected Environment _IsRework;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778384, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsMoveNonStd")]
    protected Environment _IsMoveNonStd;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778385, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsHold")]
    protected Environment _IsHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ToWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    protected Environment _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048929, false, false, true, null)]
    protected Environment _ToStep;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048929, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ToStepName")]
    protected Environment _ToStepName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_ReworkReason")]
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, false, "NamedObjectRef", 1048740, false, false, true, null)]
    protected Environment _ReworkReason;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;

    public Environment DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

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

    public Environment DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultPEDescription));
      }
    }

    public Environment ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Environment ESigRequirement
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

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment TimerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerAction));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public Environment BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment IsBusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBusinessRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsBusinessRule));
      }
    }

    public Environment IsProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsProductionEvent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsProductionEvent));
      }
    }

    public Environment IsRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRework), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRework));
      }
    }

    public Environment IsMoveNonStd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsMoveNonStd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsMoveNonStd));
      }
    }

    public Environment IsHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsHold));
      }
    }

    public Environment ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
      }
    }

    public Environment ToStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStepName));
      }
    }

    public Environment ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
