// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryHistoryDetail
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
  public class ChecklistEntryHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_UserComments")]
    protected Primitive<string> _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ResponseLayout")]
    protected Enumeration<ResponseLayoutCtrlEnum, int> _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ResponseEntryControl")]
    protected Enumeration<UIControlTypeEnum, int> _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ResponseSet")]
    protected NamedObjectRef _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_CommentsEntry")]
    protected Enumeration<ChecklistCommentCtrlEnum, int> _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ChecklistEntry")]
    protected NamedSubentityRef _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_ChecklistText")]
    protected Primitive<string> _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryHistoryDetail_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChecklistEntryHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((ChecklistEntryHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._Sequence, (object) ((ChecklistEntryHistoryDetail) obj)._Sequence) && object.Equals((object) this._UserComments, (object) ((ChecklistEntryHistoryDetail) obj)._UserComments)) && (object.Equals((object) this._ResponseLayout, (object) ((ChecklistEntryHistoryDetail) obj)._ResponseLayout) && object.Equals((object) this._ResponseEntryControl, (object) ((ChecklistEntryHistoryDetail) obj)._ResponseEntryControl) && (object.Equals((object) this._ResponseSet, (object) ((ChecklistEntryHistoryDetail) obj)._ResponseSet) && object.Equals((object) this._CommentsEntry, (object) ((ChecklistEntryHistoryDetail) obj)._CommentsEntry))) && (object.Equals((object) this._ChecklistEntry, (object) ((ChecklistEntryHistoryDetail) obj)._ChecklistEntry) && object.Equals((object) this._EntryRequired, (object) ((ChecklistEntryHistoryDetail) obj)._EntryRequired) && (object.Equals((object) this._HistoryId, (object) ((ChecklistEntryHistoryDetail) obj)._HistoryId) && object.Equals((object) this._ChecklistText, (object) ((ChecklistEntryHistoryDetail) obj)._ChecklistText)) && object.Equals((object) this._Name, (object) ((ChecklistEntryHistoryDetail) obj)._Name)) && base.Equals(obj);
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

    public NamedSubentityRef ChecklistEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntry), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChecklistEntry));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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

    public Primitive<string> Name
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
