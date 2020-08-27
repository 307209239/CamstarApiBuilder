// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseHistoryDetail
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
  public class EventFailureCauseHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_CauseCode")]
    protected NamedObjectRef _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_EventFailureActionHistoryDetails")]
    protected SubentityRef[] _EventFailureActionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_IsRootCause")]
    protected Primitive<bool> _IsRootCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is EventFailureCauseHistoryDetail && object.Equals((object) this._Comments, (object) ((EventFailureCauseHistoryDetail) obj)._Comments) && (object.Equals((object) this._CauseCode, (object) ((EventFailureCauseHistoryDetail) obj)._CauseCode) && object.Equals((object) this._FailureMode, (object) ((EventFailureCauseHistoryDetail) obj)._FailureMode)) && (object.Equals((object) this._ExportImportKey, (object) ((EventFailureCauseHistoryDetail) obj)._ExportImportKey) && this.CompareArrays((Array) this._EventFailureActionHistoryDetails, (Array) ((EventFailureCauseHistoryDetail) obj)._EventFailureActionHistoryDetails) && (object.Equals((object) this._IsRootCause, (object) ((EventFailureCauseHistoryDetail) obj)._IsRootCause) && object.Equals((object) this._HistoryId, (object) ((EventFailureCauseHistoryDetail) obj)._HistoryId))) && base.Equals(obj);
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

    public SubentityRef[] EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
      }
    }

    public Primitive<bool> IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRootCause));
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
