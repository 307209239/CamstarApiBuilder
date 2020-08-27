// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistDetail
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
  public class ExecuteChecklistDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_UserComments")]
    protected Primitive<string> _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_UserResponses")]
    protected ExecuteChklstResponseDtl[] _UserResponses;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_ResponseSet")]
    protected NamedObjectRef _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_ChecklistEntry")]
    protected NamedSubentityRef _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_ResponseEntryControl")]
    protected Enumeration<UIControlTypeEnum, int> _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_CommentsEntry")]
    protected Enumeration<ChecklistCommentCtrlEnum, int> _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_ResponseLayout")]
    protected Enumeration<ResponseLayoutCtrlEnum, int> _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_LastCompletedBy")]
    protected Primitive<string> _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_LastCompletedByRole")]
    protected Primitive<string> _LastCompletedByRole;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_ChecklistText")]
    protected Primitive<string> _ChecklistText;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChecklistDetail && object.Equals((object) this._UserComments, (object) ((ExecuteChecklistDetail) obj)._UserComments) && (this.CompareArrays((Array) this._UserResponses, (Array) ((ExecuteChecklistDetail) obj)._UserResponses) && object.Equals((object) this._ResponseSet, (object) ((ExecuteChecklistDetail) obj)._ResponseSet)) && (object.Equals((object) this._ChecklistEntry, (object) ((ExecuteChecklistDetail) obj)._ChecklistEntry) && object.Equals((object) this._ResponseEntryControl, (object) ((ExecuteChecklistDetail) obj)._ResponseEntryControl) && (object.Equals((object) this._CommentsEntry, (object) ((ExecuteChecklistDetail) obj)._CommentsEntry) && object.Equals((object) this._ResponseLayout, (object) ((ExecuteChecklistDetail) obj)._ResponseLayout))) && (object.Equals((object) this._EntryRequired, (object) ((ExecuteChecklistDetail) obj)._EntryRequired) && object.Equals((object) this._LastCompletedOnGMT, (object) ((ExecuteChecklistDetail) obj)._LastCompletedOnGMT) && (object.Equals((object) this._LastCompletedBy, (object) ((ExecuteChecklistDetail) obj)._LastCompletedBy) && object.Equals((object) this._LastCompletedByRole, (object) ((ExecuteChecklistDetail) obj)._LastCompletedByRole)) && object.Equals((object) this._ChecklistText, (object) ((ExecuteChecklistDetail) obj)._ChecklistText)) && base.Equals(obj);
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

    public ExecuteChklstResponseDtl[] UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseDtl[]) this.PropertyGet(nameof (UserResponses));
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

    public Primitive<string> LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastCompletedBy));
      }
    }

    public Primitive<string> LastCompletedByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedByRole), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastCompletedByRole));
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
  }
}
