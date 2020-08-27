// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkg_Environment
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
  public class DeployChangePkg_Environment : ChangeMgtTxn_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 16777625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_CPExportStatus")]
    [Metadata("ExportImportStatusType", "ExportImportStatusEnum", false, false, false, "Integer", 16777399, false, false, false, null)]
    protected Environment _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_ServiceDetail")]
    [Metadata("Deploy details for a change package.", "DeployChangePkgDetail", false, false, false, "DeployChangePkgDetail", 1051158, false, false, false, null)]
    protected DeployChangePkgDetail_Environment _ServiceDetail;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1053240, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_ChangePackage")]
    protected new Environment _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_BuildTimestamp")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777398, false, false, false, null)]
    protected Environment _BuildTimestamp;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777398, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_BuildTimestampGMT")]
    protected Environment _BuildTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Environment_PreReqChangePkgs")]
    [Metadata("Generic String", "", false, false, false, "String", 16778970, false, true, false, null)]
    protected Environment _PreReqChangePkgs;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public DeployChangePkgDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (DeployChangePkgDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment BuildTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BuildTimestamp));
      }
    }

    public Environment BuildTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestampGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BuildTimestampGMT));
      }
    }

    public Environment PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }
  }
}
