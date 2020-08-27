// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkgDetail_Info
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
  public class DeployChangePkgDetail_Info : ChangePackageDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_Info_TargetDeployments")]
    protected TargetDeploymentDetail_Info _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgDetail_Info_TargetSystems")]
    protected new TargetSystemDetail_Info _TargetSystems;

    public TargetDeploymentDetail_Info TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Info) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public new TargetSystemDetail_Info TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (TargetSystemDetail_Info) this.PropertyGet(nameof (TargetSystems));
      }
    }
  }
}
