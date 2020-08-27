// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPAHistory_Info
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
  public class CreateCAPAHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_HistoryDetails")]
    protected CAPAHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_QualityCrossRefHistories")]
    protected QualityCrossRefHistory_Info _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Info_CAPAName")]
    protected Info _CAPAName;

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

    public CAPAHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CAPAHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public QualityCrossRefHistory_Info QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory_Info) this.PropertyGet(nameof (QualityCrossRefHistories));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
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

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }

    public Info CAPAName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPAName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CAPAName));
      }
    }
  }
}
