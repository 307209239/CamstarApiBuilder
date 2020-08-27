// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityReportConfigChanges
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
  public class QualityReportConfigChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_ReportPage")]
    protected NamedObjectRef _ReportPage;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityReportConfigChanges_ReportAction")]
    protected Primitive<string> _ReportAction;

    public override bool Equals(object obj)
    {
      return obj is QualityReportConfigChanges && object.Equals((object) this._Category, (object) ((QualityReportConfigChanges) obj)._Category) && (object.Equals((object) this._ReportPage, (object) ((QualityReportConfigChanges) obj)._ReportPage) && object.Equals((object) this._SubClassification, (object) ((QualityReportConfigChanges) obj)._SubClassification)) && (object.Equals((object) this._Classification, (object) ((QualityReportConfigChanges) obj)._Classification) && object.Equals((object) this._ReportAction, (object) ((QualityReportConfigChanges) obj)._ReportAction)) && base.Equals(obj);
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

    public NamedObjectRef ReportPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReportPage));
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

    public Primitive<string> ReportAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportAction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportAction));
      }
    }
  }
}
