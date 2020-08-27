// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiryDetail
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
  public class PackageInquiryDetail : ChangePackageInquiryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_PackageStatus")]
    protected Enumeration<PackageStatusEnum, int> _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_TargetDeployments")]
    protected TargetDeploymentDetail[] _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_TargetSystems")]
    protected TargetSystemDetail[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_Obj_Inst")]
    protected Primitive<string> _Obj_Inst;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_InstanceCount")]
    protected Primitive<int> _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_ObjectCount")]
    protected Primitive<int> _ObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiryDetail_TargetCount")]
    protected Primitive<int> _TargetCount;

    public override bool Equals(object obj)
    {
      return obj is PackageInquiryDetail && object.Equals((object) this._PackageStatus, (object) ((PackageInquiryDetail) obj)._PackageStatus) && (this.CompareArrays((Array) this._TargetDeployments, (Array) ((PackageInquiryDetail) obj)._TargetDeployments) && this.CompareArrays((Array) this._TargetSystems, (Array) ((PackageInquiryDetail) obj)._TargetSystems)) && (object.Equals((object) this._Obj_Inst, (object) ((PackageInquiryDetail) obj)._Obj_Inst) && object.Equals((object) this._InstanceCount, (object) ((PackageInquiryDetail) obj)._InstanceCount) && (object.Equals((object) this._ObjectCount, (object) ((PackageInquiryDetail) obj)._ObjectCount) && object.Equals((object) this._TargetCount, (object) ((PackageInquiryDetail) obj)._TargetCount))) && base.Equals(obj);
    }

    public Enumeration<PackageStatusEnum, int> PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>) this.PropertyGet(nameof (PackageStatus));
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

    public Primitive<string> Obj_Inst
    {
      [param: In] set
      {
        this.PropertySet(nameof (Obj_Inst), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Obj_Inst));
      }
    }

    public Primitive<int> InstanceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (InstanceCount));
      }
    }

    public Primitive<int> ObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectCount));
      }
    }

    public Primitive<int> TargetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TargetCount));
      }
    }
  }
}
