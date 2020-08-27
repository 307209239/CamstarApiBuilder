// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskHistory
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
  public class DelegateTaskHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_DelegationReasonCode")]
    protected NamedObjectRef _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_DelegationTarget")]
    protected BaseObjectRef _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_SourceEmployee")]
    protected NamedObjectRef _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_TargetEmployee")]
    protected NamedObjectRef _TargetEmployee;

    public override bool Equals(object obj)
    {
      return obj is DelegateTaskHistory && object.Equals((object) this._Comments, (object) ((DelegateTaskHistory) obj)._Comments) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((DelegateTaskHistory) obj)._HistoryDetails) && object.Equals((object) this._ExportImportKey, (object) ((DelegateTaskHistory) obj)._ExportImportKey)) && (object.Equals((object) this._DelegationReasonCode, (object) ((DelegateTaskHistory) obj)._DelegationReasonCode) && object.Equals((object) this._DelegationTarget, (object) ((DelegateTaskHistory) obj)._DelegationTarget) && (object.Equals((object) this._HistoryId, (object) ((DelegateTaskHistory) obj)._HistoryId) && object.Equals((object) this._SourceEmployee, (object) ((DelegateTaskHistory) obj)._SourceEmployee))) && object.Equals((object) this._TargetEmployee, (object) ((DelegateTaskHistory) obj)._TargetEmployee) && base.Equals(obj);
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public NamedObjectRef DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public BaseObjectRef DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (DelegationTarget));
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

    public NamedObjectRef SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SourceEmployee));
      }
    }

    public NamedObjectRef TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
