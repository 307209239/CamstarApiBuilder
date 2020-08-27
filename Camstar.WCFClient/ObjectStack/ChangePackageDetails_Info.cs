// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetails_Info
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
  public class ChangePackageDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_PreReqChangePkgs")]
    protected PackageInquiryDetail_Info _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_TargetDeployments")]
    protected TargetDeploymentDetail_Info _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_Instances")]
    protected CPModelingInstanceDtl_Info _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_TargetSystems")]
    protected TargetSystemDetail_Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_LastUpdatedDateGMT")]
    protected Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_CreationDateGMT")]
    protected Info _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_Author")]
    protected Info _Author;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Info_CreationReason")]
    protected Info _CreationReason;

    public PackageInquiryDetail_Info PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Info) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetDeploymentDetail_Info TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Info) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public CPModelingInstanceDtl_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (Instances));
      }
    }

    public TargetSystemDetail_Info TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (TargetSystemDetail_Info) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Info LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Info CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Info Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Priority));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Info Author
    {
      [param: In] set
      {
        this.PropertySet(nameof (Author), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Author));
      }
    }

    public Info PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageType));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info CreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationReason));
      }
    }
  }
}
