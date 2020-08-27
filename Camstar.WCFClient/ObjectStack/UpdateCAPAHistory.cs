// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateCAPAHistory
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
  public class UpdateCAPAHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_QualityCrossRefHistories")]
    protected QualityCrossRefHistory[] _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_HistoryDetails")]
    protected CAPAHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPAHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is UpdateCAPAHistory && object.Equals((object) this._ExportImportKey, (object) ((UpdateCAPAHistory) obj)._ExportImportKey) && (this.CompareArrays((Array) this._QualityCrossRefHistories, (Array) ((UpdateCAPAHistory) obj)._QualityCrossRefHistories) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((UpdateCAPAHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Organization, (object) ((UpdateCAPAHistory) obj)._Organization) && object.Equals((object) this._SubClassification, (object) ((UpdateCAPAHistory) obj)._SubClassification) && (object.Equals((object) this._Classification, (object) ((UpdateCAPAHistory) obj)._Classification) && object.Equals((object) this._Submit, (object) ((UpdateCAPAHistory) obj)._Submit))) && object.Equals((object) this._HistoryId, (object) ((UpdateCAPAHistory) obj)._HistoryId) && base.Equals(obj);
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

    public QualityCrossRefHistory[] QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory[]) this.PropertyGet(nameof (QualityCrossRefHistories));
      }
    }

    public CAPAHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CAPAHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
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
