// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProcessModelChanges_Environment))]
  [KnownType(typeof (PlanChanges_Environment))]
  [KnownType(typeof (ActivityChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PhaseChanges_Environment))]
  [Serializable]
  public class ProcessObjectChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_AssigneeRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051574, false, false, true, null)]
    protected Environment _AssigneeRole;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_ReassignmentComments")]
    protected Environment _ReassignmentComments;
    [Metadata("Field Expression.", "", false, false, false, "String", 1051388, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_RuleList")]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Description")]
    [Metadata("Instruction", "", false, false, false, "String", 1051642, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, null)]
    protected Environment _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "NamedSubentityRef", 1051405, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Prerequisites")]
    protected Environment _Prerequisites;
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, false, "Integer", 1052113, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_AllowReassignment")]
    protected Environment _AllowReassignment;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollectionChanges", false, false, false, "DataPointCollectionChanges", 1052416, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_DataPointCollection")]
    protected DataPointCollectionChanges_Environment _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_ListItemToChange")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_LastStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1052085, false, false, false, "0")]
    protected Environment _LastStage;
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, false, "Integer", 1052123, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_AssigneeOption")]
    protected Environment _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051375, false, false, true, null)]
    protected Environment _CompleteWithinUOM;
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "ChecklistChanges", false, false, false, "ChecklistChanges", 1052398, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Checklist")]
    protected ChecklistChanges_Environment _Checklist;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1049090, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Details")]
    protected ProcessObjectChanges_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_AutoStart")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051697, false, false, false, "0")]
    protected Environment _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_AutoComplete")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051785, false, false, false, "0")]
    protected Environment _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051374, false, false, false, null)]
    protected Environment _CompleteWithinQty;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_OnHold")]
    protected Environment _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_DefaultAssigneeInfo")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052021, false, false, false, "0")]
    protected Environment _DefaultAssigneeInfo;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_IsRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049018, false, false, false, "0")]
    protected Environment _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Assignee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051372, false, false, true, null)]
    protected Environment _Assignee;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1052111, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;

    public Environment AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Environment ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public Environment RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleList));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
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

    public Environment Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Environment AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public DataPointCollectionChanges_Environment DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollectionChanges_Environment) this.PropertyGet(nameof (DataPointCollection));
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

    public Environment LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStage));
      }
    }

    public Environment AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public Environment CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public ChecklistChanges_Environment Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (ChecklistChanges_Environment) this.PropertyGet(nameof (Checklist));
      }
    }

    public ProcessObjectChanges_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public Environment AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Environment AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Environment CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Environment OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnHold));
      }
    }

    public Environment DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultAssigneeInfo));
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

    public Environment IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Environment Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Assignee));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
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
  }
}
