// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntryChanges_Environment
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
  public class ApprovalSheetEntryChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_ApproverRole")]
    protected Environment _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_PLMApprovalURL")]
    [Metadata("URL", "", false, false, false, "String", 16777612, false, false, false, null)]
    protected Environment _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_SpecialInstructions")]
    [Metadata("Comments", "", false, false, false, "String", 1051983, false, false, false, null)]
    protected Environment _SpecialInstructions;
    [Metadata("Brief Description", "", false, false, false, "String", 16777611, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_PLMApprovalCode")]
    protected Environment _PLMApprovalCode;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("ApprovalSubstituteOption", "ApprovalSubstituteOptionEnum", false, true, false, "Integer", 1051982, false, false, true, "2")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_SubstituteOption")]
    protected Environment _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_EditOption")]
    [Metadata("ApprovalEditOption", "ApprovalEditOptionEnum", false, true, false, "Integer", 1051981, false, false, true, "1")]
    protected Environment _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051692, false, false, true, null)]
    protected Environment _CompleteWithinUOM;
    [Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, false, "Integer", 1051610, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_DecisionType")]
    protected Environment _DecisionType;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntryChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_LastRoutedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051994, false, false, false, null)]
    protected Environment _LastRoutedOnGMT;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048809, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_SheetLevel")]
    protected Environment _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_EntryRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051980, false, false, false, "0")]
    protected Environment _EntryRequired;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051684, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_FirstRoutedOn")]
    protected Environment _FirstRoutedOn;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051993, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_LastRoutedOn")]
    protected Environment _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    protected Environment _CompleteWithinQty;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051991, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_Approver")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048681, false, false, true, null)]
    protected Environment _Approver;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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
  }
}
