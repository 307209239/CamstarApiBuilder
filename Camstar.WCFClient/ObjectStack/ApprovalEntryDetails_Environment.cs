// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalEntryDetails_Environment
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
  public class ApprovalEntryDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1051983, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [Metadata("URL", "", false, false, false, "String", 16777612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_PLMApprovalURL")]
    protected Environment _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_ApprovalComments")]
    [Metadata("Comments", "", false, false, true, "String", 1051641, false, false, false, null)]
    protected Environment _ApprovalComments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_ApproverRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    protected Environment _ApproverRole;
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1051625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_ApprovalDecision")]
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, false, true, "NamedSubentityRef", 1051875, false, false, true, null)]
    protected Environment _ApprovalDecision;
    [Metadata("ApprovalEditOption", "ApprovalEditOptionEnum", false, false, false, "Integer", 1051981, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_EditOption")]
    protected Environment _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_SubstituteOption")]
    [Metadata("ApprovalSubstituteOption", "ApprovalSubstituteOptionEnum", false, false, false, "Integer", 1051982, false, false, true, null)]
    protected Environment _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_ApprovalEntry")]
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, false, "SubentityRef", 1051627, false, false, false, null)]
    protected Environment _ApprovalEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051375, false, false, true, null)]
    protected Environment _CompleteWithinUOM;
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTask", false, false, false, "SubentityRef", 16778787, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_DelegationTask")]
    protected Environment _DelegationTask;
    [Metadata("Brief Description", "", false, false, false, "String", 16777611, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_PLMApprovalCode")]
    protected Environment _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_ApprovalDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051680, false, false, false, null)]
    protected Environment _ApprovalDate;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051374, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_CompleteWithinQty")]
    protected Environment _CompleteWithinQty;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_CompleteBy")]
    protected Environment _CompleteBy;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051684, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_FirstRoutedOn")]
    protected Environment _FirstRoutedOn;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051980, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_EntryRequired")]
    protected Environment _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_SheetLevel")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048809, false, false, false, "0")]
    protected Environment _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_Approver")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048681, false, false, true, null)]
    protected Environment _Approver;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Environment_AssignedApprover")]
    protected Environment _AssignedApprover;

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

    public Environment PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Environment ApprovalComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalComments));
      }
    }

    public Environment ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApproverRole));
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

    public Environment ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Environment EditOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (EditOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EditOption));
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

    public Environment ApprovalEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalEntry));
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

    public Environment PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public Environment ApprovalDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalDate));
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

    public Environment CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteBy));
      }
    }

    public Environment FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public Environment EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryRequired));
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

    public Environment Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Approver));
      }
    }

    public Environment AssignedApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedApprover), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedApprover));
      }
    }
  }
}
