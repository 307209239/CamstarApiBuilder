// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPAHistory
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
  public class CreateCAPAHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_HistoryDetails")]
    protected CAPAHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_QualityCrossRefHistories")]
    protected QualityCrossRefHistory[] _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_CAPAName")]
    protected Primitive<string> _CAPAName;

    public override bool Equals(object obj)
    {
      return obj is CreateCAPAHistory && object.Equals((object) this._Category, (object) ((CreateCAPAHistory) obj)._Category) && (object.Equals((object) this._ExportImportKey, (object) ((CreateCAPAHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CreateCAPAHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Classification, (object) ((CreateCAPAHistory) obj)._Classification) && this.CompareArrays((Array) this._QualityCrossRefHistories, (Array) ((CreateCAPAHistory) obj)._QualityCrossRefHistories) && (object.Equals((object) this._SubClassification, (object) ((CreateCAPAHistory) obj)._SubClassification) && object.Equals((object) this._Organization, (object) ((CreateCAPAHistory) obj)._Organization))) && (object.Equals((object) this._HistoryId, (object) ((CreateCAPAHistory) obj)._HistoryId) && object.Equals((object) this._Submit, (object) ((CreateCAPAHistory) obj)._Submit) && object.Equals((object) this._CAPAName, (object) ((CreateCAPAHistory) obj)._CAPAName)) && base.Equals(obj);
    }

    public Enumeration<CategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (Category));
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

    public Primitive<string> CAPAName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPAName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CAPAName));
      }
    }
  }
}
