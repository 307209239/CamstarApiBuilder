// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntry
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
  public class ChecklistEntry : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_UserComments")]
    protected Primitive<string> _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_LastCompletedByRole")]
    protected NamedObjectRef _LastCompletedByRole;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ResponseSet")]
    protected NamedObjectRef _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ActualResponses")]
    protected ChecklistActualResponse[] _ActualResponses;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_CommentsEntry")]
    protected Enumeration<ChecklistCommentCtrlEnum, int> _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ResponseLayout")]
    protected Enumeration<ResponseLayoutCtrlEnum, int> _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ResponseEntryControl")]
    protected Enumeration<UIControlTypeEnum, int> _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_LastCompletedOn")]
    protected Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_LastCompletedBy")]
    protected NamedObjectRef _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_ChecklistText")]
    protected Primitive<string> _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ChecklistEntry && object.Equals((object) this._Sequence, (object) ((ChecklistEntry) obj)._Sequence) && (object.Equals((object) this._UserComments, (object) ((ChecklistEntry) obj)._UserComments) && object.Equals((object) this._LastCompletedByRole, (object) ((ChecklistEntry) obj)._LastCompletedByRole)) && (object.Equals((object) this._ExportImportKey, (object) ((ChecklistEntry) obj)._ExportImportKey) && object.Equals((object) this._ResponseSet, (object) ((ChecklistEntry) obj)._ResponseSet) && (this.CompareArrays((Array) this._ActualResponses, (Array) ((ChecklistEntry) obj)._ActualResponses) && object.Equals((object) this._CommentsEntry, (object) ((ChecklistEntry) obj)._CommentsEntry))) && (object.Equals((object) this._ResponseLayout, (object) ((ChecklistEntry) obj)._ResponseLayout) && object.Equals((object) this._ResponseEntryControl, (object) ((ChecklistEntry) obj)._ResponseEntryControl) && (object.Equals((object) this._LastCompletedOn, (object) ((ChecklistEntry) obj)._LastCompletedOn) && object.Equals((object) this._LastCompletedOnGMT, (object) ((ChecklistEntry) obj)._LastCompletedOnGMT)) && (object.Equals((object) this._EntryRequired, (object) ((ChecklistEntry) obj)._EntryRequired) && object.Equals((object) this._LastCompletedBy, (object) ((ChecklistEntry) obj)._LastCompletedBy) && (object.Equals((object) this._ChecklistText, (object) ((ChecklistEntry) obj)._ChecklistText) && object.Equals((object) this._Name, (object) ((ChecklistEntry) obj)._Name)))) && object.Equals((object) this._IsFrozen, (object) ((ChecklistEntry) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<string> UserComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserComments));
      }
    }

    public NamedObjectRef LastCompletedByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedByRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastCompletedByRole));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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

    public ChecklistActualResponse[] ActualResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualResponses), (object) value);
      }
      get
      {
        return (ChecklistActualResponse[]) this.PropertyGet(nameof (ActualResponses));
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

    public Primitive<DateTime> LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Primitive<DateTime> LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOnGMT));
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

    public NamedObjectRef LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastCompletedBy));
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
