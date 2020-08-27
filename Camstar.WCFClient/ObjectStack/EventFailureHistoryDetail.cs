// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureHistoryDetail
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
  public class EventFailureHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_EventFailureCauseHistoryDetails")]
    protected EventFailureCauseHistoryDetail[] _EventFailureCauseHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is EventFailureHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((EventFailureHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._FailureSeverity, (object) ((EventFailureHistoryDetail) obj)._FailureSeverity) && object.Equals((object) this._FailureType, (object) ((EventFailureHistoryDetail) obj)._FailureType)) && (object.Equals((object) this._Comments, (object) ((EventFailureHistoryDetail) obj)._Comments) && object.Equals((object) this._FailureMode, (object) ((EventFailureHistoryDetail) obj)._FailureMode) && (this.CompareArrays((Array) this._EventFailureCauseHistoryDetails, (Array) ((EventFailureHistoryDetail) obj)._EventFailureCauseHistoryDetails) && object.Equals((object) this._HistoryId, (object) ((EventFailureHistoryDetail) obj)._HistoryId))) && object.Equals((object) this._Description, (object) ((EventFailureHistoryDetail) obj)._Description) && base.Equals(obj);
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

    public NamedObjectRef FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public NamedObjectRef FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureType));
      }
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

    public EventFailureCauseHistoryDetail[] EventFailureCauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseHistoryDetail[]) this.PropertyGet(nameof (EventFailureCauseHistoryDetails));
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
