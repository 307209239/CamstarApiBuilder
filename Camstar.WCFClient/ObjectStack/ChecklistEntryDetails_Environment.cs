// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryDetails_Environment
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
  public class ChecklistEntryDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_UserComments")]
    protected Environment _UserComments;
    [Metadata("Enumeration for the Response Layout:\r\nBelowHorizontal = 1\r\nBelowVertical = 2\r\nRight = 3\r\nLeft = 4", "ResponseLayoutCtrlEnum", false, false, false, "Integer", 1052395, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_ResponseLayout")]
    protected Environment _ResponseLayout;
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntry", false, false, false, "NamedSubentityRef", 1052421, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_ChecklistEntry")]
    protected Environment _ChecklistEntry;
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, false, "NamedObjectRef", 1052374, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_ResponseSet")]
    protected Environment _ResponseSet;
    [Metadata("Enumeration for ControlType\r\n1 = RadioButton\r\n2 = CheckBox\r\n3 = Picklist", "UIControlTypeEnum", false, false, false, "Integer", 1052379, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_ResponseEntryControl")]
    protected Environment _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_CommentsEntry")]
    [Metadata("Enumeration for ChecklistCommentCtrl\r\n1 = NoComments\r\n2 = CommentsAllowed\r\n3 = CommentsRequired", "ChecklistCommentCtrlEnum", false, false, false, "Integer", 1052383, false, false, true, null)]
    protected Environment _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_EntryRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052378, false, false, false, "0")]
    protected Environment _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_ChecklistText")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1052377, false, false, false, null)]
    protected Environment _ChecklistText;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Environment_Name")]
    protected Environment _Name;

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
