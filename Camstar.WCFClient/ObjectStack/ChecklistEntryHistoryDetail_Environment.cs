// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryHistoryDetail_Environment
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
  public class ChecklistEntryHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_UserComments")]
    [Metadata("Comments", "", false, false, true, "String", 1048621, false, false, false, null)]
    protected Environment _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ResponseLayout")]
    [Metadata("Enumeration for the Response Layout:\r\nBelowHorizontal = 1\r\nBelowVertical = 2\r\nRight = 3\r\nLeft = 4", "ResponseLayoutCtrlEnum", false, false, true, "Integer", 1052395, false, false, false, null)]
    protected Environment _ResponseLayout;
    [Metadata("Enumeration for ControlType\r\n1 = RadioButton\r\n2 = CheckBox\r\n3 = Picklist", "UIControlTypeEnum", false, false, true, "Integer", 1052379, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ResponseEntryControl")]
    protected Environment _ResponseEntryControl;
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, true, "NamedObjectRef", 1052374, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ResponseSet")]
    protected Environment _ResponseSet;
    [Metadata("Enumeration for ChecklistCommentCtrl\r\n1 = NoComments\r\n2 = CommentsAllowed\r\n3 = CommentsRequired", "ChecklistCommentCtrlEnum", false, false, true, "Integer", 1052383, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_CommentsEntry")]
    protected Environment _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ChecklistEntry")]
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntry", false, false, true, "NamedSubentityRef", 1052421, false, false, false, null)]
    protected Environment _ChecklistEntry;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051980, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_EntryRequired")]
    protected Environment _EntryRequired;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1052422, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_ChecklistText")]
    protected Environment _ChecklistText;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Environment_Name")]
    protected Environment _Name;

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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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

    public Environment Name
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
  }
}
