// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiry_Environment
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
  public class ActivationInquiry_Environment : ChangePackageInquiry_Environment
  {
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_PackageStatusFilter")]
    protected Environment _PackageStatusFilter;
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_PackageStatus")]
    protected Environment _PackageStatus;
    [Metadata("Details about  a change package inquiry.", "ActivationInquiryDetail", false, false, false, "ActivationInquiryDetail", 16777345, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_PackageDetails")]
    protected ActivationInquiryDetail_Environment _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_SourceSystem")]
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 16777320, false, false, true, null)]
    protected Environment _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_ActivationStatus")]
    [Metadata("ChangePackageImportStatus", "ChangePackageImportStatusEnum", false, false, false, "Integer", 16777379, false, true, true, null)]
    protected Environment _ActivationStatus;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777384, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_ToDeploymentTimestamp")]
    protected Environment _ToDeploymentTimestamp;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777383, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_FromDeploymentTimestamp")]
    protected Environment _FromDeploymentTimestamp;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777353, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_PackageOwnerName")]
    protected Environment _PackageOwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiry_Environment_SourceSystemName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777418, false, false, true, null)]
    protected Environment _SourceSystemName;

    public Environment PackageStatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatusFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageStatusFilter));
      }
    }

    public Environment PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public ActivationInquiryDetail_Environment PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ActivationInquiryDetail_Environment) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public Environment SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Environment ActivationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivationStatus));
      }
    }

    public Environment ToDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToDeploymentTimestamp));
      }
    }

    public Environment FromDeploymentTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromDeploymentTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromDeploymentTimestamp));
      }
    }

    public Environment PackageOwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwnerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageOwnerName));
      }
    }

    public Environment SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceSystemName));
      }
    }
  }
}
