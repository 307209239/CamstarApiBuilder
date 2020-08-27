// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntry_Environment
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
  public class ApprovalSheetEntry_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Comments", "", false, false, true, "String", 1051983, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_ApproverRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    protected Environment _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_PLMApprovalURL")]
    [Metadata("URL", "", false, false, true, "String", 16777612, false, false, false, null)]
    protected Environment _PLMApprovalURL;
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTask", false, false, true, "SubentityRef", 16778752, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_DelegationTask")]
    protected Environment _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_PLMApprovalCode")]
    [Metadata("Brief Description", "", false, false, true, "String", 16777611, false, false, false, null)]
    protected Environment _PLMApprovalCode;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, true, "String", 1051692, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_CompleteWithinUOM")]
    protected Environment _CompleteWithinUOM;
    [Metadata("History of the Sign Approval transactions", "SignApprovalHistory", false, false, true, "SubentityRef", 1051657, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_LastDecision")]
    protected Environment _LastDecision;
    [Metadata("ApprovalSubstituteOption", "ApprovalSubstituteOptionEnum", false, false, true, "Integer", 1051982, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_SubstituteOption")]
    protected Environment _SubstituteOption;
    [Metadata("ApprovalEditOption", "ApprovalEditOptionEnum", false, false, true, "Integer", 1051981, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_EditOption")]
    protected Environment _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_ApprovalDecision")]
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, false, true, "NamedSubentityRef", 1051620, false, false, false, null)]
    protected Environment _ApprovalDecision;
    [Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, true, "Integer", 1051610, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_DecisionType")]
    protected Environment _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_Status")]
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1051625, false, false, false, null)]
    protected Environment _Status;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_CompleteBy")]
    protected Environment _CompleteBy;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051536, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_FirstRoutedOnGMT")]
    protected Environment _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    protected Environment _CompleteWithinQty;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_LastCompletedOn")]
    protected Environment _LastCompletedOn;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051893, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_LastCompletedOnGMT")]
    protected Environment _LastCompletedOnGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051684, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_FirstRoutedOn")]
    protected Environment _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_SheetLevel")]
    [Metadata("Generic Integer", "", false, true, true, "Integer", 1048809, false, false, false, "0")]
    protected Environment _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_LastRoutedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051993, false, false, false, null)]
    protected Environment _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_LastRoutedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051994, false, false, false, null)]
    protected Environment _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_EntryRequired")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051980, false, false, false, "0")]
    protected Environment _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_ObjectToApprove")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051623, false, false, false, null)]
    protected Environment _ObjectToApprove;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051991, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1051409, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_CompleteWithin")]
    protected Environment _CompleteWithin;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_AssignedApprover")]
    protected Environment _AssignedApprover;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_ApprovedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052266, false, false, false, null)]
    protected Environment _ApprovedBy;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Environment_Approver")]
    protected Environment _Approver;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public Environment Comments
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

    public Environment LastDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDecision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDecision));
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

    public Environment DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionType));
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

    public Environment FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstRoutedOnGMT));
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

    public Environment LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Environment LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOnGMT));
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

    public Environment LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Environment LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRoutedOnGMT));
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

    public Environment ObjectToApprove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToApprove), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToApprove));
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

    public Environment ApprovedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovedBy));
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
  }
}
