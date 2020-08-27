// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryDetails_Environment
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
  public class CollaboratorEntryDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_Role")]
    protected Environment _Role;
    [Metadata("Instruction", "", false, false, false, "String", 1050514, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CollaboratorComments")]
    [Metadata("Comments", "", false, false, false, "String", 16778093, false, false, false, null)]
    protected Environment _CollaboratorComments;
    [Metadata("Status of collaboration process:\r\n1 - Pending\r\n2 - Late\r\n3 - Complete", "CollaborateStatusEnum", false, false, false, "Integer", 1048671, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_Status")]
    protected Environment _Status;
    [Metadata("An entry in an collaborator sheet specifies the details for a single collaborator.", "CollaboratorEntry", false, false, false, "SubentityRef", 16778088, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CollaboratorEntry")]
    protected Environment _CollaboratorEntry;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051375, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_DurationUOM")]
    protected Environment _DurationUOM;
    [Metadata("ApprovalSubstituteOption", "ApprovalSubstituteOptionEnum", false, false, false, "Integer", 1051982, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_SubstituteOption")]
    protected Environment _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_DelegationTask")]
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTask", false, false, false, "SubentityRef", 16778787, false, false, false, null)]
    protected Environment _DelegationTask;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048809, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_SheetLevel")]
    protected Environment _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_IsAbleToComplete")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778879, false, false, false, "0")]
    protected Environment _IsAbleToComplete;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778880, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_IsDefaultToComplete")]
    protected Environment _IsDefaultToComplete;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_DueDateGMT")]
    protected Environment _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_AssignedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052310, false, false, false, null)]
    protected Environment _AssignedDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CompletionDateGMT")]
    protected Environment _CompletionDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051991, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1051409, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CompleteWithin")]
    protected Environment _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_CompletedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051683, false, false, false, null)]
    protected Environment _CompletedBy;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1051374, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_Duration")]
    protected Environment _Duration;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_AssignedCollaborator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778777, false, false, false, null)]
    protected Environment _AssignedCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Environment_Collaborator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048681, false, false, true, null)]
    protected Environment _Collaborator;

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Environment CollaboratorComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorComments));
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

    public Environment CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public Environment DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DurationUOM));
      }
    }

    public Environment SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Environment DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Environment SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Environment IsAbleToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAbleToComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAbleToComplete));
      }
    }

    public Environment IsDefaultToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultToComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDefaultToComplete));
      }
    }

    public Environment DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Environment AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Environment CompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionDateGMT));
      }
    }

    public Environment CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Environment CompleteWithin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithin));
      }
    }

    public Environment CompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletedBy));
      }
    }

    public Environment Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Duration));
      }
    }

    public Environment AssignedCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedCollaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedCollaborator));
      }
    }

    public Environment Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Collaborator));
      }
    }
  }
}
