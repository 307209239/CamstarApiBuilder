// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (StartChangePkgDetail_Info))]
  [KnownType(typeof (UpdateChangePkgDetail_Info))]
  [KnownType(typeof (AssignChangePkgContentDtl_Info))]
  [KnownType(typeof (DeployChangePkgDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangePackageDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_Info_TargetSystems")]
    protected TargetSystemDetail_Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageDetail_Info_Instances")]
    protected CPModelingInstanceDtl_Info _Instances;

    public TargetSystemDetail_Info TargetSystems
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

    public CPModelingInstanceDtl_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
