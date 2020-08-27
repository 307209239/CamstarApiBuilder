// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkg
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
  public class DeployChangePkg : ChangeMgtTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_CPExportStatus")]
    protected Enumeration<ExportImportStatusEnum, int> _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_ServiceDetail")]
    protected DeployChangePkgDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_ChangePackage")]
    protected new NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_BuildTimestamp")]
    protected Primitive<DateTime> _BuildTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_BuildTimestampGMT")]
    protected Primitive<DateTime> _BuildTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkg_PreReqChangePkgs")]
    protected Primitive<string>[] _PreReqChangePkgs;

    public override bool Equals(object obj)
    {
      return obj is DeployChangePkg && object.Equals((object) this._Comments, (object) ((DeployChangePkg) obj)._Comments) && (object.Equals((object) this._CPExportStatus, (object) ((DeployChangePkg) obj)._CPExportStatus) && object.Equals((object) this._ServiceDetail, (object) ((DeployChangePkg) obj)._ServiceDetail)) && (object.Equals((object) this._ChangePackage, (object) ((DeployChangePkg) obj)._ChangePackage) && object.Equals((object) this._BuildTimestamp, (object) ((DeployChangePkg) obj)._BuildTimestamp) && (object.Equals((object) this._BuildTimestampGMT, (object) ((DeployChangePkg) obj)._BuildTimestampGMT) && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((DeployChangePkg) obj)._PreReqChangePkgs))) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Enumeration<ExportImportStatusEnum, int> CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportStatusEnum, int>) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public DeployChangePkgDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (DeployChangePkgDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Primitive<DateTime> BuildTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (BuildTimestamp));
      }
    }

    public Primitive<DateTime> BuildTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuildTimestampGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (BuildTimestampGMT));
      }
    }

    public Primitive<string>[] PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }
  }
}
