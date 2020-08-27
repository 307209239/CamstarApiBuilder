// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResolveCARRefHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QualityCrossRefHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_TrackingId")]
    protected NamedObjectRef _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_CrossReference")]
    protected NamedObjectRef _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_CloseReference")]
    protected Primitive<bool> _CloseReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_ExecuteAction")]
    protected Primitive<int> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_CloseDescription")]
    protected Primitive<string> _CloseDescription;

    public override bool Equals(object obj)
    {
      return obj is QualityCrossRefHistory && object.Equals((object) this._TrackingId, (object) ((QualityCrossRefHistory) obj)._TrackingId) && (object.Equals((object) this._ExportImportKey, (object) ((QualityCrossRefHistory) obj)._ExportImportKey) && object.Equals((object) this._CrossReference, (object) ((QualityCrossRefHistory) obj)._CrossReference)) && (object.Equals((object) this._QualityResolutionCode, (object) ((QualityCrossRefHistory) obj)._QualityResolutionCode) && object.Equals((object) this._CloseReference, (object) ((QualityCrossRefHistory) obj)._CloseReference) && (object.Equals((object) this._HistoryId, (object) ((QualityCrossRefHistory) obj)._HistoryId) && object.Equals((object) this._ExecuteAction, (object) ((QualityCrossRefHistory) obj)._ExecuteAction))) && object.Equals((object) this._CloseDescription, (object) ((QualityCrossRefHistory) obj)._CloseDescription) && base.Equals(obj);
    }

    public NamedObjectRef TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrackingId));
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

    public NamedObjectRef CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CrossReference));
      }
    }

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Primitive<bool> CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseReference));
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

    public Primitive<int> ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
