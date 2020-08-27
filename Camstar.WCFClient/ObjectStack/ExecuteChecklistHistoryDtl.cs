// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistoryDtl
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
  public class ExecuteChecklistHistoryDtl : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_UserComments")]
    protected Primitive<string> _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_ChecklistText")]
    protected Primitive<string> _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_ChecklistEntry")]
    protected NamedSubentityRef _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_ResponseSet")]
    protected NamedObjectRef _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_UserResponses")]
    protected ExecuteChklstResponseHistDtl[] _UserResponses;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChecklistHistoryDtl && object.Equals((object) this._ExportImportKey, (object) ((ExecuteChecklistHistoryDtl) obj)._ExportImportKey) && (object.Equals((object) this._UserComments, (object) ((ExecuteChecklistHistoryDtl) obj)._UserComments) && object.Equals((object) this._ChecklistText, (object) ((ExecuteChecklistHistoryDtl) obj)._ChecklistText)) && (object.Equals((object) this._ChecklistEntry, (object) ((ExecuteChecklistHistoryDtl) obj)._ChecklistEntry) && object.Equals((object) this._ResponseSet, (object) ((ExecuteChecklistHistoryDtl) obj)._ResponseSet) && (this.CompareArrays((Array) this._UserResponses, (Array) ((ExecuteChecklistHistoryDtl) obj)._UserResponses) && object.Equals((object) this._HistoryId, (object) ((ExecuteChecklistHistoryDtl) obj)._HistoryId))) && base.Equals(obj);
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

    public ExecuteChklstResponseHistDtl[] UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseHistDtl[]) this.PropertyGet(nameof (UserResponses));
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
  }
}
