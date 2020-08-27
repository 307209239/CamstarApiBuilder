// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplate_Environment
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
  public class PlanTemplate_Environment : ProcessObjectTemplate_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051574, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AssigneeRole")]
    protected new Environment _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Description")]
    [Metadata("Instruction", "", false, false, true, "String", 1051642, false, false, false, null)]
    protected new Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Organizations")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, true, false, null)]
    protected new Environment _Organizations;
    [Metadata("Business Rule Data", "BusinessRuleData", false, false, true, "BusinessRuleData", 1052119, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_onCompleteRules")]
    protected BusinessRuleData_Environment _onCompleteRules;
    [Metadata("Business Rule Data", "BusinessRuleData", false, false, true, "BusinessRuleData", 1052120, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_onStartRules")]
    protected BusinessRuleData_Environment _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    protected new Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Checklist")]
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, true, "Checklist", 1052398, false, false, false, null)]
    protected new Checklist_Environment _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_ApprovalSheets")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "ApprovalSheet", 1052012, false, true, false, null)]
    protected ApprovalSheet_Environment _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AllowReassignment")]
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, true, "Integer", 1052113, false, false, false, null)]
    protected new Environment _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, true, "String", 1051692, false, false, false, null)]
    protected new Environment _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AssigneeOption")]
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, true, "Integer", 1052123, false, false, false, null)]
    protected new Environment _AssigneeOption;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_InstanceLocked")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    protected new Environment _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AutoStart")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051697, false, false, false, "0")]
    protected new Environment _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_DefaultAssigneeInfo")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052021, false, false, false, "0")]
    protected new Environment _DefaultAssigneeInfo;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_IsRequired")]
    protected new Environment _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AutoComplete")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051785, false, false, false, "0")]
    protected new Environment _AutoComplete;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051371, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_ApprovalRequired")]
    protected new Environment _ApprovalRequired;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_AssociatedPackages")]
    protected new Environment _AssociatedPackages;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051372, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Assignee")]
    protected new Environment _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_ChangeHistory")]
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    protected new ChangeHistory_Environment _ChangeHistory;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1052111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_DocumentSet")]
    protected new Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Notes")]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_IconId")]
    protected new Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplate_Environment_Status")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    protected new Environment _Status;

    public new Environment AssigneeRole
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

    public new Environment Organizations
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

    public BusinessRuleData_Environment onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Environment) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public BusinessRuleData_Environment onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Environment) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Checklist_Environment Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist_Environment) this.PropertyGet(nameof (Checklist));
      }
    }

    public new Environment ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public ApprovalSheet_Environment ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheet_Environment) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new Environment AllowReassignment
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

    public new Environment CompleteWithinUOM
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

    public new Environment AssigneeOption
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

    public new Environment InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Environment CompleteWithinQty
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

    public new Environment AutoStart
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

    public new Environment DefaultAssigneeInfo
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

    public new Environment IsRequired
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

    public new Environment AutoComplete
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

    public new Environment ApprovalRequired
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

    public new Environment AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Environment Assignee
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

    public new ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Environment DocumentSet
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

    public new Environment Notes
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

    public new Environment IsFrozen
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

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public new Environment Status
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
