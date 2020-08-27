// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryChanges
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
  public class ChecklistEntryChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_ResponseLayout")]
    protected Enumeration<ResponseLayoutCtrlEnum, int> _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_CommentsEntry")]
    protected Enumeration<ChecklistCommentCtrlEnum, int> _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_ResponseSet")]
    protected NamedObjectRef _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_ResponseEntryControl")]
    protected Enumeration<UIControlTypeEnum, int> _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_ChecklistText")]
    protected Primitive<string> _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChecklistEntryChanges && object.Equals((object) this._Sequence, (object) ((ChecklistEntryChanges) obj)._Sequence) && (object.Equals((object) this._ResponseLayout, (object) ((ChecklistEntryChanges) obj)._ResponseLayout) && object.Equals((object) this._CommentsEntry, (object) ((ChecklistEntryChanges) obj)._CommentsEntry)) && (object.Equals((object) this._ResponseSet, (object) ((ChecklistEntryChanges) obj)._ResponseSet) && object.Equals((object) this._ResponseEntryControl, (object) ((ChecklistEntryChanges) obj)._ResponseEntryControl) && (object.Equals((object) this._EntryRequired, (object) ((ChecklistEntryChanges) obj)._EntryRequired) && object.Equals((object) this._ChecklistText, (object) ((ChecklistEntryChanges) obj)._ChecklistText))) && object.Equals((object) this._Name, (object) ((ChecklistEntryChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Enumeration<ResponseLayoutCtrlEnum, int> ResponseLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLayout), (object) value);
      }
      get
      {
        return (Enumeration<ResponseLayoutCtrlEnum, int>) this.PropertyGet(nameof (ResponseLayout));
      }
    }

    public Enumeration<ChecklistCommentCtrlEnum, int> CommentsEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentsEntry), (object) value);
      }
      get
      {
        return (Enumeration<ChecklistCommentCtrlEnum, int>) this.PropertyGet(nameof (CommentsEntry));
      }
    }

    public NamedObjectRef ResponseSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResponseSet));
      }
    }

    public Enumeration<UIControlTypeEnum, int> ResponseEntryControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseEntryControl), (object) value);
      }
      get
      {
        return (Enumeration<UIControlTypeEnum, int>) this.PropertyGet(nameof (ResponseEntryControl));
      }
    }

    public Primitive<bool> EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EntryRequired));
      }
    }

    public Primitive<string> ChecklistText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChecklistText));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
