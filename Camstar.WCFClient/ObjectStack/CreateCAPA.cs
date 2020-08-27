// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPA
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
  public class CreateCAPA : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_QualityCrossRefDetails")]
    protected QualityCrossRefDetail[] _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_ServiceDetail")]
    protected CAPADetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_CAPAName")]
    protected Primitive<string> _CAPAName;

    public override bool Equals(object obj)
    {
      return obj is CreateCAPA && object.Equals((object) this._Category, (object) ((CreateCAPA) obj)._Category) && (object.Equals((object) this._SubClassification, (object) ((CreateCAPA) obj)._SubClassification) && object.Equals((object) this._QualityObject, (object) ((CreateCAPA) obj)._QualityObject)) && (object.Equals((object) this._Classification, (object) ((CreateCAPA) obj)._Classification) && this.CompareArrays((Array) this._QualityCrossRefDetails, (Array) ((CreateCAPA) obj)._QualityCrossRefDetails) && (object.Equals((object) this._Organization, (object) ((CreateCAPA) obj)._Organization) && object.Equals((object) this._ServiceDetail, (object) ((CreateCAPA) obj)._ServiceDetail))) && (object.Equals((object) this._Submit, (object) ((CreateCAPA) obj)._Submit) && object.Equals((object) this._CAPAName, (object) ((CreateCAPA) obj)._CAPAName)) && base.Equals(obj);
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

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
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

    public QualityCrossRefDetail[] QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail[]) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public new NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public CAPADetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (CAPADetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }

    public Primitive<string> CAPAName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPAName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CAPAName));
      }
    }
  }
}
