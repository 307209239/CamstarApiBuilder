// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityProcessingMapChanges_Environment
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
  public class QualityProcessingMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Environment_Category")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, true, false, "Integer", 1051206, false, false, true, null)]
    protected Environment _Category;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1052104, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Environment_SubClassification")]
    protected Environment _SubClassification;
    [Metadata("Quality Object Label Map", "QualityObjectLabelMapChanges", false, false, false, "QualityObjectLabelMapChanges", 1052532, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Environment_LabelTxnMap")]
    protected QualityObjectLabelMapChanges_Environment _LabelTxnMap;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Environment_Classification")]
    protected Environment _Classification;

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

    public QualityObjectLabelMapChanges_Environment LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (QualityObjectLabelMapChanges_Environment) this.PropertyGet(nameof (LabelTxnMap));
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
  }
}
