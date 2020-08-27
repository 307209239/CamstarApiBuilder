// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityReportConfigChanges_Environment
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
  public class QualityReportConfigChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Environment_Category")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, true, false, "Integer", 1051206, false, false, true, null)]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Environment_ReportPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, true, false, "NamedObjectRef", 1052209, false, false, true, null)]
    protected Environment _ReportPage;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, true, false, "NamedObjectRef", 1052104, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Environment_SubClassification")]
    protected Environment _SubClassification;
    [Metadata("Used to classify QualityObjects", "Classification", false, true, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Environment_Classification")]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Environment_ReportAction")]
    [Metadata("Generic String", "", false, true, false, "String", 1052133, false, false, false, null)]
    protected Environment _ReportAction;

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

    public Environment ReportPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportPage));
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

    public Environment ReportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportAction));
      }
    }
  }
}
