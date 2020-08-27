// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiryDetail_Info
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
  public class PackageInquiryDetail_Info : ChangePackageInquiryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_PackageStatus")]
    protected Info _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_TargetDeployments")]
    protected TargetDeploymentDetail_Info _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_TargetSystems")]
    protected TargetSystemDetail_Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_Obj_Inst")]
    protected Info _Obj_Inst;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_InstanceCount")]
    protected Info _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_ObjectCount")]
    protected Info _ObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Info_TargetCount")]
    protected Info _TargetCount;

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

    public Info Obj_Inst
    {
      [param: In] set
      {
        this.PropertySet(nameof (Obj_Inst), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Obj_Inst));
      }
    }

    public Info InstanceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceCount));
      }
    }

    public Info ObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectCount));
      }
    }

    public Info TargetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetCount));
      }
    }
  }
}
