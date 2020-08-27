// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiryDetail_Environment
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
  public class PackageInquiryDetail_Environment : ChangePackageInquiryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_PackageStatus")]
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, true, "Integer", 16778128, false, false, true, null)]
    protected Environment _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_TargetDeployments")]
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, false, "TargetDeploymentDetail", 16777400, false, true, false, null)]
    protected TargetDeploymentDetail_Environment _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_TargetSystems")]
    [Metadata("Target System Detail", "TargetSystemDetail", false, false, false, "TargetSystemDetail", 1053270, false, true, false, null)]
    protected TargetSystemDetail_Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_Obj_Inst")]
    [Metadata("Generic String", "", false, false, false, "String", 16777376, false, false, false, null)]
    protected Environment _Obj_Inst;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777378, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_InstanceCount")]
    protected Environment _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_ObjectCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777388, false, false, false, null)]
    protected Environment _ObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Environment_TargetCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777387, false, false, false, null)]
    protected Environment _TargetCount;

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

    public Environment Obj_Inst
    {
      [param: In] set
      {
        this.PropertySet(nameof (Obj_Inst), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Obj_Inst));
      }
    }

    public Environment InstanceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceCount));
      }
    }

    public Environment ObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectCount));
      }
    }

    public Environment TargetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetCount));
      }
    }
  }
}
