// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureActionHistoryDtl
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
  public class EventFailureActionHistoryDtl : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_CauseCode")]
    protected NamedObjectRef _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_ActionType")]
    protected NamedObjectRef _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_CompletionDate")]
    protected Primitive<DateTime> _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_ActionOwner")]
    protected NamedObjectRef _ActionOwner;

    public override bool Equals(object obj)
    {
      return obj is EventFailureActionHistoryDtl && object.Equals((object) this._Comments, (object) ((EventFailureActionHistoryDtl) obj)._Comments) && (object.Equals((object) this._FailureMode, (object) ((EventFailureActionHistoryDtl) obj)._FailureMode) && object.Equals((object) this._CauseCode, (object) ((EventFailureActionHistoryDtl) obj)._CauseCode)) && (object.Equals((object) this._ExportImportKey, (object) ((EventFailureActionHistoryDtl) obj)._ExportImportKey) && object.Equals((object) this._ActionType, (object) ((EventFailureActionHistoryDtl) obj)._ActionType) && (object.Equals((object) this._CompletionDate, (object) ((EventFailureActionHistoryDtl) obj)._CompletionDate) && object.Equals((object) this._HistoryId, (object) ((EventFailureActionHistoryDtl) obj)._HistoryId))) && object.Equals((object) this._ActionOwner, (object) ((EventFailureActionHistoryDtl) obj)._ActionOwner) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureMode));
      }
    }

    public NamedObjectRef CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CauseCode));
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

    public NamedObjectRef ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionType));
      }
    }

    public Primitive<DateTime> CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionDate));
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

    public NamedObjectRef ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
