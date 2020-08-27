// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObjectHistory
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
  public class TriageQualityObjectHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_QualityObjectRole")]
    protected NamedObjectRef _QualityObjectRole;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_TriageSpecDetail")]
    protected NamedSubentityRef _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_ProcessModelTemplate")]
    protected RevisionedObjectRef _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_RouteProcessModel")]
    protected Primitive<bool> _RouteProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_IsCARRequiredToClose")]
    protected Primitive<bool> _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_QualityObjectOwner")]
    protected NamedObjectRef _QualityObjectOwner;

    public override bool Equals(object obj)
    {
      return obj is TriageQualityObjectHistory && object.Equals((object) this._QualityObjectRole, (object) ((TriageQualityObjectHistory) obj)._QualityObjectRole) && (object.Equals((object) this._Category, (object) ((TriageQualityObjectHistory) obj)._Category) && object.Equals((object) this._ExportImportKey, (object) ((TriageQualityObjectHistory) obj)._ExportImportKey)) && (object.Equals((object) this._PriorityLevel, (object) ((TriageQualityObjectHistory) obj)._PriorityLevel) && object.Equals((object) this._TriageSpecDetail, (object) ((TriageQualityObjectHistory) obj)._TriageSpecDetail) && (object.Equals((object) this._ProcessModelTemplate, (object) ((TriageQualityObjectHistory) obj)._ProcessModelTemplate) && object.Equals((object) this._RouteProcessModel, (object) ((TriageQualityObjectHistory) obj)._RouteProcessModel))) && (object.Equals((object) this._TriageComplete, (object) ((TriageQualityObjectHistory) obj)._TriageComplete) && object.Equals((object) this._IsCARRequiredToClose, (object) ((TriageQualityObjectHistory) obj)._IsCARRequiredToClose) && (object.Equals((object) this._HistoryId, (object) ((TriageQualityObjectHistory) obj)._HistoryId) && object.Equals((object) this._QualityObjectOwner, (object) ((TriageQualityObjectHistory) obj)._QualityObjectOwner))) && base.Equals(obj);
    }

    public NamedObjectRef QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObjectRole));
      }
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

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public NamedSubentityRef TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public RevisionedObjectRef ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public Primitive<bool> RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Primitive<bool> IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsCARRequiredToClose));
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

    public NamedObjectRef QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
