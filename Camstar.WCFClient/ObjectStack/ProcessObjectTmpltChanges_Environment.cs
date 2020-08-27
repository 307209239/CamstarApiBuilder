// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTmpltChanges_Environment
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
  public class ProcessObjectTmpltChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, null)]
    protected Environment _ExecutionContextType;
    [Metadata("Field Expression.", "", false, false, false, "String", 1051388, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_RuleList")]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Description")]
    [Metadata("Instruction", "", false, false, false, "String", 1051642, false, false, false, null)]
    protected new Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_AssigneeRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051574, false, false, true, null)]
    protected Environment _AssigneeRole;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Organizations")]
    protected Environment _Organizations;
    [Metadata("An abstract class to define the common fields", "ProcessObjectTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Checklist")]
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "ChecklistChanges", false, false, false, "ChecklistChanges", 1052398, false, false, false, null)]
    protected ChecklistChanges_Environment _Checklist;
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, false, "Integer", 1052113, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_AllowReassignment")]
    protected Environment _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1049090, false, true, false, null)]
    protected ProcessObjectChanges_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_AssigneeOption")]
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, false, "Integer", 1052123, false, false, true, "1")]
    protected Environment _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051692, false, false, true, null)]
    protected Environment _CompleteWithinUOM;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_CompleteWithinQty")]
    protected Environment _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_AutoStart")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051697, false, false, false, "0")]
    protected Environment _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_DefaultAssigneeInfo")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052021, false, false, false, "0")]
    protected Environment _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_ApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    protected Environment _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_AutoComplete")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051785, false, false, false, "0")]
    protected Environment _AutoComplete;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_IsRequired")]
    protected Environment _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1052111, false, false, true, null)]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Assignee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051372, false, false, true, null)]
    protected Environment _Assignee;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Environment_Status")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    protected Environment _Status;

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

    public new Environment Description
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

    public Environment Organizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organizations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organizations));
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

    public Environment ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalRequired));
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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }
  }
}
