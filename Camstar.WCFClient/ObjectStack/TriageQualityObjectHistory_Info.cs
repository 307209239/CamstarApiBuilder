// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObjectHistory_Info
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
  public class TriageQualityObjectHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_QualityObjectRole")]
    protected Info _QualityObjectRole;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_TriageSpecDetail")]
    protected Info _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_ProcessModelTemplate")]
    protected Info _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_RouteProcessModel")]
    protected Info _RouteProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_IsCARRequiredToClose")]
    protected Info _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObjectHistory_Info_QualityObjectOwner")]
    protected Info _QualityObjectOwner;

    public Info QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectRole));
      }
    }

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public Info ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public Info RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
