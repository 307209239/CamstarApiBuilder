// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkgDetail_Info
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
  public class StartChangePkgDetail_Info : ChangePackageDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_Info_PreReqChangePkgs")]
    protected PackageInquiryDetail_Info _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_Info_SourceSystem")]
    protected TargetSystem_Info _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgDetail_Info_TargetSystems")]
    protected new TargetSystemDetail_Info _TargetSystems;

    public PackageInquiryDetail_Info PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Info) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetSystem_Info SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Info) this.PropertyGet(nameof (SourceSystem));
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
