// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkgDetail
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
  public class DeployChangePkgDetail : ChangePackageDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_TargetDeployments")]
    protected TargetDeploymentDetail[] _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_TargetSystems")]
    protected new TargetSystemDetail[] _TargetSystems;

    public override bool Equals(object obj)
    {
      return obj is DeployChangePkgDetail && this.CompareArrays((Array) this._TargetDeployments, (Array) ((DeployChangePkgDetail) obj)._TargetDeployments) && this.CompareArrays((Array) this._TargetSystems, (Array) ((DeployChangePkgDetail) obj)._TargetSystems) && base.Equals(obj);
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
