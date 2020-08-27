// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiry
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
  public class ActivationInquiry : ChangePackageInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_PackageStatusFilter")]
    protected Enumeration<PackageStatusEnum, int>[] _PackageStatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_PackageStatus")]
    protected Enumeration<PackageStatusEnum, int>[] _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_PackageDetails")]
    protected ActivationInquiryDetail[] _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_SourceSystem")]
    protected NamedObjectRef _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_ActivationStatus")]
    protected Enumeration<ChangePackageImportStatusEnum, int>[] _ActivationStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_ToDeploymentTimestamp")]
    protected Primitive<DateTime> _ToDeploymentTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_FromDeploymentTimestamp")]
    protected Primitive<DateTime> _FromDeploymentTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_PackageOwnerName")]
    protected Primitive<string> _PackageOwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_SourceSystemName")]
    protected Primitive<string> _SourceSystemName;

    public override bool Equals(object obj)
    {
      return obj is ActivationInquiry && this.CompareArrays((Array) this._PackageStatusFilter, (Array) ((ActivationInquiry) obj)._PackageStatusFilter) && (this.CompareArrays((Array) this._PackageStatus, (Array) ((ActivationInquiry) obj)._PackageStatus) && this.CompareArrays((Array) this._PackageDetails, (Array) ((ActivationInquiry) obj)._PackageDetails)) && (object.Equals((object) this._SourceSystem, (object) ((ActivationInquiry) obj)._SourceSystem) && this.CompareArrays((Array) this._ActivationStatus, (Array) ((ActivationInquiry) obj)._ActivationStatus) && (object.Equals((object) this._ToDeploymentTimestamp, (object) ((ActivationInquiry) obj)._ToDeploymentTimestamp) && object.Equals((object) this._FromDeploymentTimestamp, (object) ((ActivationInquiry) obj)._FromDeploymentTimestamp))) && (object.Equals((object) this._PackageOwnerName, (object) ((ActivationInquiry) obj)._PackageOwnerName) && object.Equals((object) this._SourceSystemName, (object) ((ActivationInquiry) obj)._SourceSystemName)) && base.Equals(obj);
    }

    public Enumeration<PackageStatusEnum, int>[] PackageStatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatusFilter), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>[]) this.PropertyGet(nameof (PackageStatusFilter));
      }
    }

    public Enumeration<PackageStatusEnum, int>[] PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>[]) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public ActivationInquiryDetail[] PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ActivationInquiryDetail[]) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public NamedObjectRef SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Enumeration<ChangePackageImportStatusEnum, int>[] ActivationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationStatus), (object) value);
      }
      get
      {
        return (Enumeration<ChangePackageImportStatusEnum, int>[]) this.PropertyGet(nameof (ActivationStatus));
      }
    }

    public Primitive<DateTime> ToDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ToDeploymentTimestamp));
      }
    }

    public Primitive<DateTime> FromDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FromDeploymentTimestamp));
      }
    }

    public Primitive<string> PackageOwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageOwnerName));
      }
    }

    public Primitive<string> SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceSystemName));
      }
    }
  }
}
