// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiryDetail
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
  public class ActivationInquiryDetail : ChangePackageInquiryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_PackageStatus")]
    protected Enumeration<PackageStatusEnum, int> _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_ActivationStatus")]
    protected Enumeration<ChangePackageImportStatusEnum, int> _ActivationStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_InstanceCount")]
    protected Primitive<int> _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_DeployTimestampGMT")]
    protected Primitive<DateTime> _DeployTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_ObjectCount")]
    protected Primitive<int> _ObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Obj_Inst")]
    protected Primitive<string> _Obj_Inst;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_DeployTimestamp")]
    protected Primitive<DateTime> _DeployTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_SourceSystem")]
    protected Primitive<string> _SourceSystem;

    public override bool Equals(object obj)
    {
      return obj is ActivationInquiryDetail && object.Equals((object) this._PackageStatus, (object) ((ActivationInquiryDetail) obj)._PackageStatus) && (object.Equals((object) this._ActivationStatus, (object) ((ActivationInquiryDetail) obj)._ActivationStatus) && object.Equals((object) this._InstanceCount, (object) ((ActivationInquiryDetail) obj)._InstanceCount)) && (object.Equals((object) this._DeployTimestampGMT, (object) ((ActivationInquiryDetail) obj)._DeployTimestampGMT) && object.Equals((object) this._ObjectCount, (object) ((ActivationInquiryDetail) obj)._ObjectCount) && (object.Equals((object) this._Obj_Inst, (object) ((ActivationInquiryDetail) obj)._Obj_Inst) && object.Equals((object) this._DeployTimestamp, (object) ((ActivationInquiryDetail) obj)._DeployTimestamp))) && object.Equals((object) this._SourceSystem, (object) ((ActivationInquiryDetail) obj)._SourceSystem) && base.Equals(obj);
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

    public Enumeration<ChangePackageImportStatusEnum, int> ActivationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationStatus), (object) value);
      }
      get
      {
        return (Enumeration<ChangePackageImportStatusEnum, int>) this.PropertyGet(nameof (ActivationStatus));
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

    public Primitive<DateTime> DeployTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestampGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DeployTimestampGMT));
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

    public Primitive<DateTime> DeployTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DeployTimestamp));
      }
    }

    public Primitive<string> SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceSystem));
      }
    }
  }
}
