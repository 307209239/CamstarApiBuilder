// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntry_Environment
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
  public class ChecklistEntry_Environment : NamedSubentity_Environment
  {
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_UserComments")]
    protected Environment _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_LastCompletedByRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1052446, false, false, false, null)]
    protected Environment _LastCompletedByRole;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ResponseSet")]
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, true, "NamedObjectRef", 1052374, false, false, false, null)]
    protected Environment _ResponseSet;
    [Metadata("The actual response(s) saved for a ChecklistEntry during ExecuteChecklist transaction.", "ChecklistActualResponse", false, false, true, "ChecklistActualResponse", 1052435, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ActualResponses")]
    protected ChecklistActualResponse_Environment _ActualResponses;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_CommentsEntry")]
    [Metadata("Enumeration for ChecklistCommentCtrl\r\n1 = NoComments\r\n2 = CommentsAllowed\r\n3 = CommentsRequired", "ChecklistCommentCtrlEnum", false, false, true, "Integer", 1052386, false, false, false, null)]
    protected Environment _CommentsEntry;
    [Metadata("Enumeration for the Response Layout:\r\nBelowHorizontal = 1\r\nBelowVertical = 2\r\nRight = 3\r\nLeft = 4", "ResponseLayoutCtrlEnum", false, false, true, "Integer", 1052395, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ResponseLayout")]
    protected Environment _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ResponseEntryControl")]
    [Metadata("Enumeration for ControlType\r\n1 = RadioButton\r\n2 = CheckBox\r\n3 = Picklist", "UIControlTypeEnum", false, false, true, "Integer", 1052379, false, false, false, null)]
    protected Environment _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_LastCompletedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051534, false, false, false, null)]
    protected Environment _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_LastCompletedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051992, false, false, false, null)]
    protected Environment _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_EntryRequired")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052378, false, false, false, "0")]
    protected Environment _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_LastCompletedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052445, false, false, false, null)]
    protected Environment _LastCompletedBy;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1052377, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_ChecklistText")]
    protected Environment _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052376, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

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

    public Environment UserComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserComments));
      }
    }

    public Environment LastCompletedByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedByRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedByRole));
      }
    }

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

    public Environment ResponseSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseSet));
      }
    }

    public ChecklistActualResponse_Environment ActualResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualResponses), (object) value);
      }
      get
      {
        return (ChecklistActualResponse_Environment) this.PropertyGet(nameof (ActualResponses));
      }
    }

    public Environment CommentsEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentsEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CommentsEntry));
      }
    }

    public Environment ResponseLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLayout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseLayout));
      }
    }

    public Environment ResponseEntryControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseEntryControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseEntryControl));
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

    public Environment LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedBy));
      }
    }

    public Environment ChecklistText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistText));
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
  }
}
