// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistDetail_Environment
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
  public class ExecuteChecklistDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_UserComments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _UserComments;
    [Metadata("Response for an entry in the Checklist.", "ExecuteChklstResponseDtl", false, false, false, "ExecuteChklstResponseDtl", 1052419, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_UserResponses")]
    protected ExecuteChklstResponseDtl_Environment _UserResponses;
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, false, "NamedObjectRef", 1052374, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_ResponseSet")]
    protected Environment _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_ChecklistEntry")]
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntry", false, true, false, "NamedSubentityRef", 1052421, false, false, false, null)]
    protected Environment _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_ResponseEntryControl")]
    [Metadata("Enumeration for ControlType\r\n1 = RadioButton\r\n2 = CheckBox\r\n3 = Picklist", "UIControlTypeEnum", false, false, false, "Integer", 1052379, false, false, false, null)]
    protected Environment _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_CommentsEntry")]
    [Metadata("Enumeration for ChecklistCommentCtrl\r\n1 = NoComments\r\n2 = CommentsAllowed\r\n3 = CommentsRequired", "ChecklistCommentCtrlEnum", false, false, false, "Integer", 1052386, false, false, false, null)]
    protected Environment _CommentsEntry;
    [Metadata("Enumeration for the Response Layout:\r\nBelowHorizontal = 1\r\nBelowVertical = 2\r\nRight = 3\r\nLeft = 4", "ResponseLayoutCtrlEnum", false, false, false, "Integer", 1052395, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_ResponseLayout")]
    protected Environment _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_EntryRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051980, false, false, false, "0")]
    protected Environment _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_LastCompletedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051992, false, false, false, null)]
    protected Environment _LastCompletedOnGMT;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052445, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_LastCompletedBy")]
    protected Environment _LastCompletedBy;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_LastCompletedByRole")]
    protected Environment _LastCompletedByRole;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1052422, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Environment_ChecklistText")]
    protected Environment _ChecklistText;

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

    public ExecuteChklstResponseDtl_Environment UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseDtl_Environment) this.PropertyGet(nameof (UserResponses));
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

    public Environment ChecklistEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistEntry));
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
  }
}
