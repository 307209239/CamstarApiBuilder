// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryChanges_Environment
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
  public class ChecklistEntryChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_ResponseLayout")]
    [Metadata("Enumeration for the Response Layout:\r\nBelowHorizontal = 1\r\nBelowVertical = 2\r\nRight = 3\r\nLeft = 4", "ResponseLayoutCtrlEnum", false, false, false, "Integer", 1052395, false, false, true, "2")]
    protected Environment _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_CommentsEntry")]
    [Metadata("Enumeration for ChecklistCommentCtrl\r\n1 = NoComments\r\n2 = CommentsAllowed\r\n3 = CommentsRequired", "ChecklistCommentCtrlEnum", false, false, false, "Integer", 1052386, false, false, true, "1")]
    protected Environment _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_ResponseSet")]
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, false, "NamedObjectRef", 1052374, false, false, true, null)]
    protected Environment _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_ResponseEntryControl")]
    [Metadata("Enumeration for ControlType\r\n1 = RadioButton\r\n2 = CheckBox\r\n3 = Picklist", "UIControlTypeEnum", false, false, false, "Integer", 1052379, false, false, true, null)]
    protected Environment _ResponseEntryControl;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052378, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_EntryRequired")]
    protected Environment _EntryRequired;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, true, false, "String", 1052377, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_ChecklistText")]
    protected Environment _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052376, false, false, false, null)]
    protected new Environment _Name;

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
  }
}
