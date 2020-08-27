// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetails
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
  public class ChangePackageDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_PreReqChangePkgs")]
    protected PackageInquiryDetail[] _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_TargetDeployments")]
    protected TargetDeploymentDetail[] _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Instances")]
    protected CPModelingInstanceDtl[] _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_TargetSystems")]
    protected TargetSystemDetail[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_LastUpdatedDateGMT")]
    protected Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Priority")]
    protected Primitive<string> _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Owner")]
    protected Primitive<string> _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_OwnerRole")]
    protected Primitive<string> _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Author")]
    protected Primitive<string> _Author;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_PackageType")]
    protected Primitive<string> _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetails_CreationReason")]
    protected Primitive<string> _CreationReason;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageDetails && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((ChangePackageDetails) obj)._PreReqChangePkgs) && (this.CompareArrays((Array) this._TargetDeployments, (Array) ((ChangePackageDetails) obj)._TargetDeployments) && this.CompareArrays((Array) this._Instances, (Array) ((ChangePackageDetails) obj)._Instances)) && (this.CompareArrays((Array) this._TargetSystems, (Array) ((ChangePackageDetails) obj)._TargetSystems) && object.Equals((object) this._LastUpdatedDateGMT, (object) ((ChangePackageDetails) obj)._LastUpdatedDateGMT) && (object.Equals((object) this._LastUpdatedDate, (object) ((ChangePackageDetails) obj)._LastUpdatedDate) && object.Equals((object) this._CreationDateGMT, (object) ((ChangePackageDetails) obj)._CreationDateGMT))) && (object.Equals((object) this._CreationDate, (object) ((ChangePackageDetails) obj)._CreationDate) && object.Equals((object) this._RecommendedDeploymentDate, (object) ((ChangePackageDetails) obj)._RecommendedDeploymentDate) && (object.Equals((object) this._Priority, (object) ((ChangePackageDetails) obj)._Priority) && object.Equals((object) this._Owner, (object) ((ChangePackageDetails) obj)._Owner)) && (object.Equals((object) this._OwnerRole, (object) ((ChangePackageDetails) obj)._OwnerRole) && object.Equals((object) this._Author, (object) ((ChangePackageDetails) obj)._Author) && (object.Equals((object) this._PackageType, (object) ((ChangePackageDetails) obj)._PackageType) && object.Equals((object) this._Description, (object) ((ChangePackageDetails) obj)._Description)))) && object.Equals((object) this._CreationReason, (object) ((ChangePackageDetails) obj)._CreationReason) && base.Equals(obj);
    }

    public PackageInquiryDetail[] PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail[]) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetDeploymentDetail[] TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail[]) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public CPModelingInstanceDtl[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl[]) this.PropertyGet(nameof (Instances));
      }
    }

    public TargetSystemDetail[] TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (TargetSystemDetail[]) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Primitive<DateTime> LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<DateTime> RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Primitive<string> Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Priority));
      }
    }

    public Primitive<string> Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Primitive<string> Author
    {
      [param: In] set
      {
        this.PropertySet(nameof (Author), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Author));
      }
    }

    public Primitive<string> PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageType));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> CreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationReason), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CreationReason));
      }
    }
  }
}
