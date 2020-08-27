// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldReleaseHistory
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
  public class HoldReleaseHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_ReleaseReason")]
    protected NamedObjectRef _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_HistoryDetails")]
    protected HoldReleaseHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is HoldReleaseHistory && object.Equals((object) this._ReleaseReason, (object) ((HoldReleaseHistory) obj)._ReleaseReason) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((HoldReleaseHistory) obj)._HistoryDetails) && object.Equals((object) this._DisplayName, (object) ((HoldReleaseHistory) obj)._DisplayName)) && (object.Equals((object) this._ExportImportKey, (object) ((HoldReleaseHistory) obj)._ExportImportKey) && object.Equals((object) this._HoldReason, (object) ((HoldReleaseHistory) obj)._HoldReason) && object.Equals((object) this._HistoryId, (object) ((HoldReleaseHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public NamedObjectRef ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public HoldReleaseHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (HoldReleaseHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
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

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
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
