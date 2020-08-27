// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkg_Info
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
  public class DeployChangePkg_Info : ChangeMgtTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_CPExportStatus")]
    protected Info _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_ServiceDetail")]
    protected DeployChangePkgDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_ChangePackage")]
    protected new Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_BuildTimestamp")]
    protected Info _BuildTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_BuildTimestampGMT")]
    protected Info _BuildTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Info_PreReqChangePkgs")]
    protected Info _PreReqChangePkgs;

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public DeployChangePkgDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (DeployChangePkgDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Info BuildTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BuildTimestamp));
      }
    }

    public Info BuildTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestampGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BuildTimestampGMT));
      }
    }

    public Info PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }
  }
}
