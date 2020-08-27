// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityReportConfigChanges_Info
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
  public class QualityReportConfigChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Info_ReportPage")]
    protected Info _ReportPage;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Info_ReportAction")]
    protected Info _ReportAction;

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

    public Info ReportPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportPage));
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

    public Info ReportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportAction));
      }
    }
  }
}
