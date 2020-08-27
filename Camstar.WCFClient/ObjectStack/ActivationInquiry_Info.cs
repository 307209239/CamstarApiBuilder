// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiry_Info
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
  public class ActivationInquiry_Info : ChangePackageInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_PackageStatusFilter")]
    protected Info _PackageStatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_PackageStatus")]
    protected Info _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_PackageDetails")]
    protected ActivationInquiryDetail_Info _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_SourceSystem")]
    protected Info _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_ActivationStatus")]
    protected Info _ActivationStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_ToDeploymentTimestamp")]
    protected Info _ToDeploymentTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_FromDeploymentTimestamp")]
    protected Info _FromDeploymentTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_PackageOwnerName")]
    protected Info _PackageOwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Info_SourceSystemName")]
    protected Info _SourceSystemName;

    public Info PackageStatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatusFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageStatusFilter));
      }
    }

    public Info PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public ActivationInquiryDetail_Info PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ActivationInquiryDetail_Info) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public Info SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Info ActivationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivationStatus));
      }
    }

    public Info ToDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToDeploymentTimestamp));
      }
    }

    public Info FromDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromDeploymentTimestamp));
      }
    }

    public Info PackageOwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageOwnerName));
      }
    }

    public Info SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceSystemName));
      }
    }
  }
}
