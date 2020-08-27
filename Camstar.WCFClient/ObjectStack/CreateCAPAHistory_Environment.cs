// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPAHistory_Environment
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
  public class CreateCAPAHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_Category")]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("CAPA History Detail", "CAPAHistoryDetail", false, false, true, "CAPAHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_HistoryDetails")]
    protected CAPAHistoryDetail_Environment _HistoryDetails;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_Classification")]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_QualityCrossRefHistories")]
    [Metadata("QualityCrossRefHistory", "QualityCrossRefHistory", false, false, true, "QualityCrossRefHistory", 1051490, false, true, false, null)]
    protected QualityCrossRefHistory_Environment _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1051146, false, false, false, null)]
    protected Environment _SubClassification;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_Submit")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051062, false, false, false, "0")]
    protected Environment _Submit;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051332, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPAHistory_Environment_CAPAName")]
    protected Environment _CAPAName;

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public CAPAHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CAPAHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public QualityCrossRefHistory_Environment QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory_Environment) this.PropertyGet(nameof (QualityCrossRefHistories));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }

    public Environment CAPAName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPAName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CAPAName));
      }
    }
  }
}
