// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UpdateChangePkgDetail))]
  [KnownType(typeof (AssignChangePkgContentDtl))]
  [KnownType(typeof (StartChangePkgDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeployChangePkgDetail))]
  [Serializable]
  public class ChangePackageDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_TargetSystems")]
    protected TargetSystemDetail[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_Instances")]
    protected CPModelingInstanceDtl[] _Instances;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageDetail && this.CompareArrays((Array) this._TargetSystems, (Array) ((ChangePackageDetail) obj)._TargetSystems) && this.CompareArrays((Array) this._Instances, (Array) ((ChangePackageDetail) obj)._Instances) && base.Equals(obj);
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

    public CPModelingInstanceDtl[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl[]) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
