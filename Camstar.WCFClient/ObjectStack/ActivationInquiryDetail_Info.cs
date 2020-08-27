// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiryDetail_Info
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
  public class ActivationInquiryDetail_Info : ChangePackageInquiryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_PackageStatus")]
    protected Info _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_ActivationStatus")]
    protected Info _ActivationStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_InstanceCount")]
    protected Info _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_DeployTimestampGMT")]
    protected Info _DeployTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_ObjectCount")]
    protected Info _ObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_Obj_Inst")]
    protected Info _Obj_Inst;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_DeployTimestamp")]
    protected Info _DeployTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Info_SourceSystem")]
    protected Info _SourceSystem;

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

    public Info DeployTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestampGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeployTimestampGMT));
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

    public Info DeployTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeployTimestamp));
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
  }
}
