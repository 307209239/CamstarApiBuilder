// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateCAPA_Info
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
  public class UpdateCAPA_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_ServiceDetail")]
    protected CAPADetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_Organization")]
    protected new Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_QualityCrossRefDetails")]
    protected QualityCrossRefDetail_Info _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Info _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateCAPA_Info_Submit")]
    protected Info _Submit;

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

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public CAPADetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (CAPADetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public QualityCrossRefDetail_Info QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail_Info) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public ApprovalSheetDetails_Info ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Info) this.PropertyGet(nameof (ApprovalSheetDetails));
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

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
