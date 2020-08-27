// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetails_Environment
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
  public class ChangePackageDetails_Environment : ServiceData_Environment
  {
    [Metadata("Details returned.", "PackageInquiryDetail", false, false, false, "PackageInquiryDetail", 16778970, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_PreReqChangePkgs")]
    protected PackageInquiryDetail_Environment _PreReqChangePkgs;
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, false, "TargetDeploymentDetail", 1053268, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_TargetDeployments")]
    protected TargetDeploymentDetail_Environment _TargetDeployments;
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 1053260, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_Instances")]
    protected CPModelingInstanceDtl_Environment _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_TargetSystems")]
    [Metadata("Target System Detail", "TargetSystemDetail", false, false, false, "TargetSystemDetail", 1053270, false, true, false, null)]
    protected TargetSystemDetail_Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_LastUpdatedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053267, false, false, false, null)]
    protected Environment _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_LastUpdatedDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    protected Environment _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_CreationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049060, false, false, false, null)]
    protected Environment _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_CreationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049059, false, false, false, null)]
    protected Environment _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_RecommendedDeploymentDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778131, false, false, false, null)]
    protected Environment _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_Priority")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050015, false, false, false, null)]
    protected Environment _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_Owner")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051580, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_OwnerRole")]
    protected Environment _OwnerRole;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16777429, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_Author")]
    protected Environment _Author;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16778882, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_PackageType")]
    protected Environment _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777412, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Environment_CreationReason")]
    protected Environment _CreationReason;

    public PackageInquiryDetail_Environment PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Environment) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetDeploymentDetail_Environment TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Environment) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public CPModelingInstanceDtl_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public TargetSystemDetail_Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (TargetSystemDetail_Environment) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Environment LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
      }
    }

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public Environment OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Environment Author
    {
      [param: In] set
      {
        this.PropertySet(nameof (Author), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Author));
      }
    }

    public Environment PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageType));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment CreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationReason));
      }
    }
  }
}
