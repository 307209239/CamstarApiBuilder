// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivationInquiryDetail_Environment
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
  public class ActivationInquiryDetail_Environment : ChangePackageInquiryDetail_Environment
  {
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_PackageStatus")]
    protected Environment _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_ActivationStatus")]
    [Metadata("ChangePackageImportStatus", "ChangePackageImportStatusEnum", false, false, true, "Integer", 16777379, false, false, false, null)]
    protected Environment _ActivationStatus;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777378, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_InstanceCount")]
    protected Environment _InstanceCount;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_DeployTimestampGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777381, false, false, false, null)]
    protected Environment _DeployTimestampGMT;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777377, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_ObjectCount")]
    protected Environment _ObjectCount;
    [Metadata("Generic String", "", false, false, true, "String", 16777376, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_Obj_Inst")]
    protected Environment _Obj_Inst;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_DeployTimestamp")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777380, false, false, false, null)]
    protected Environment _DeployTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ActivationInquiryDetail_Environment_SourceSystem")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16777320, false, false, false, null)]
    protected Environment _SourceSystem;

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

    public Environment DeployTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestampGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeployTimestampGMT));
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

    public Environment DeployTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeployTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeployTimestamp));
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
  }
}
