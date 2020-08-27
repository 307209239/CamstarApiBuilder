// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkgDetail_Environment
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
  public class DeployChangePkgDetail_Environment : ChangePackageDetail_Environment
  {
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, false, "TargetDeploymentDetail", 16777400, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_Environment_TargetDeployments")]
    protected TargetDeploymentDetail_Environment _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_Environment_TargetSystems")]
    [Metadata("Target System Detail", "TargetSystemDetail", false, true, false, "TargetSystemDetail", 1053270, false, true, false, null)]
    protected new TargetSystemDetail_Environment _TargetSystems;

    public TargetDeploymentDetail_Environment TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Environment) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public new TargetSystemDetail_Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (TargetSystemDetail_Environment) this.PropertyGet(nameof (TargetSystems));
      }
    }
  }
}
