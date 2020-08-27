// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkgDetail
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
  public class StartChangePkgDetail : ChangePackageDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_PreReqChangePkgs")]
    protected PackageInquiryDetail[] _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_SourceSystem")]
    protected TargetSystem _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_TargetSystems")]
    protected new TargetSystemDetail[] _TargetSystems;

    public override bool Equals(object obj)
    {
      return obj is StartChangePkgDetail && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((StartChangePkgDetail) obj)._PreReqChangePkgs) && (object.Equals((object) this._SourceSystem, (object) ((StartChangePkgDetail) obj)._SourceSystem) && this.CompareArrays((Array) this._TargetSystems, (Array) ((StartChangePkgDetail) obj)._TargetSystems)) && base.Equals(obj);
    }

    public PackageInquiryDetail[] PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail[]) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetSystem SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public new TargetSystemDetail[] TargetSystems
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
  }
}
