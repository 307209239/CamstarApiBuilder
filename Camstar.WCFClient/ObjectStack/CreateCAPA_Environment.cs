// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPA_Environment
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
  public class CreateCAPA_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_Category")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, true, false, "Integer", 1051206, false, false, false, null)]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _SubClassification;
    [Metadata("CAPA", "CAPA", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_QualityObject")]
    protected new Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, true, null)]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_QualityCrossRefDetails")]
    [Metadata("Quality Cross Ref Detail", "QualityCrossRefDetail", false, false, false, "QualityCrossRefDetail", 1052082, false, true, false, null)]
    protected QualityCrossRefDetail_Environment _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    protected new Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_ServiceDetail")]
    [Metadata("CAPA Detail", "CAPADetail", false, false, false, "CAPADetail", 1051482, false, false, false, null)]
    protected CAPADetail_Environment _ServiceDetail;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_Submit")]
    protected Environment _Submit;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Environment_CAPAName")]
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

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
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

    public QualityCrossRefDetail_Environment QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail_Environment) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public new Environment Organization
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

    public CAPADetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (CAPADetail_Environment) this.PropertyGet(nameof (ServiceDetail));
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
