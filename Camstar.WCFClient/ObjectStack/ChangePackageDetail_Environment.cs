// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (StartChangePkgDetail_Environment))]
  [KnownType(typeof (UpdateChangePkgDetail_Environment))]
  [KnownType(typeof (DeployChangePkgDetail_Environment))]
  [KnownType(typeof (AssignChangePkgContentDtl_Environment))]
  [Serializable]
  public class ChangePackageDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Target System Detail", "TargetSystemDetail", false, false, false, "TargetSystemDetail", 1053270, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_Environment_TargetSystems")]
    protected TargetSystemDetail_Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_Environment_Instances")]
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 1053260, false, true, false, null)]
    protected CPModelingInstanceDtl_Environment _Instances;

    public TargetSystemDetail_Environment TargetSystems
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

    public CPModelingInstanceDtl_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
