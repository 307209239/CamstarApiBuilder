// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityProcessingMapChanges
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
  public class QualityProcessingMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_LabelTxnMap")]
    protected QualityObjectLabelMapChanges[] _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "QualityProcessingMapChanges_Classification")]
    protected NamedObjectRef _Classification;

    public override bool Equals(object obj)
    {
      return obj is QualityProcessingMapChanges && object.Equals((object) this._Category, (object) ((QualityProcessingMapChanges) obj)._Category) && (object.Equals((object) this._SubClassification, (object) ((QualityProcessingMapChanges) obj)._SubClassification) && this.CompareArrays((Array) this._LabelTxnMap, (Array) ((QualityProcessingMapChanges) obj)._LabelTxnMap)) && object.Equals((object) this._Classification, (object) ((QualityProcessingMapChanges) obj)._Classification) && base.Equals(obj);
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

    public QualityObjectLabelMapChanges[] LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (QualityObjectLabelMapChanges[]) this.PropertyGet(nameof (LabelTxnMap));
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
  }
}
