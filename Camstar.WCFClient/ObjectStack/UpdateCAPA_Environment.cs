// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateCAPA_Environment
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
  public class UpdateCAPA_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, true, null)]
    protected Environment _Classification;
    [Metadata("CAPA", "CAPA", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_QualityObject")]
    protected new Environment _QualityObject;
    [Metadata("CAPA Detail", "CAPADetail", false, false, false, "CAPADetail", 1051482, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_ServiceDetail")]
    protected CAPADetail_Environment _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, false, null)]
    protected new Environment _Organization;
    [Metadata("Quality Cross Ref Detail", "QualityCrossRefDetail", false, false, false, "QualityCrossRefDetail", 1052082, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_QualityCrossRefDetails")]
    protected QualityCrossRefDetail_Environment _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_ApprovalSheetDetails")]
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Environment_Submit")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    protected Environment _Submit;

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

    public ApprovalSheetDetails_Environment ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Environment) this.PropertyGet(nameof (ApprovalSheetDetails));
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
  }
}
