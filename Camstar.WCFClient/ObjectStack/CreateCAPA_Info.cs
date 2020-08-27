// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateCAPA_Info
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
  public class CreateCAPA_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_QualityCrossRefDetails")]
    protected QualityCrossRefDetail_Info _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_Organization")]
    protected new Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_ServiceDetail")]
    protected CAPADetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateCAPA_Info_CAPAName")]
    protected Info _CAPAName;

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

    public Info CAPAName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPAName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CAPAName));
      }
    }
  }
}
