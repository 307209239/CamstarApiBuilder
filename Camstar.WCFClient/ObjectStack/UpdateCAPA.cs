// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateCAPA
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
  public class UpdateCAPA : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_ServiceDetail")]
    protected CAPADetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_QualityCrossRefDetails")]
    protected QualityCrossRefDetail[] _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Submit")]
    protected Primitive<bool> _Submit;

    public override bool Equals(object obj)
    {
      return obj is UpdateCAPA && object.Equals((object) this._Classification, (object) ((UpdateCAPA) obj)._Classification) && (object.Equals((object) this._QualityObject, (object) ((UpdateCAPA) obj)._QualityObject) && object.Equals((object) this._ServiceDetail, (object) ((UpdateCAPA) obj)._ServiceDetail)) && (object.Equals((object) this._Organization, (object) ((UpdateCAPA) obj)._Organization) && this.CompareArrays((Array) this._QualityCrossRefDetails, (Array) ((UpdateCAPA) obj)._QualityCrossRefDetails) && (object.Equals((object) this._ApprovalSheetDetails, (object) ((UpdateCAPA) obj)._ApprovalSheetDetails) && object.Equals((object) this._SubClassification, (object) ((UpdateCAPA) obj)._SubClassification))) && object.Equals((object) this._Submit, (object) ((UpdateCAPA) obj)._Submit) && base.Equals(obj);
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

    public ApprovalSheetDetails ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails) this.PropertyGet(nameof (ApprovalSheetDetails));
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
  }
}
