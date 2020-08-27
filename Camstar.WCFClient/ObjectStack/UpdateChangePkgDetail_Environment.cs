// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkgDetail_Environment
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
  public class UpdateChangePkgDetail_Environment : ChangePackageDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgDetail_Environment_TargetSystems")]
    [Metadata("Target System Detail", "TargetSystemDetail", false, false, false, "TargetSystemDetail", 1053270, false, true, false, null)]
    protected new TargetSystemDetail_Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgDetail_Environment_PreReqChangePkgs")]
    [Metadata("Details returned.", "PackageInquiryDetail", false, false, false, "PackageInquiryDetail", 16778970, false, true, false, null)]
    protected PackageInquiryDetail_Environment _PreReqChangePkgs;
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, true, "TargetSystem", 16777320, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgDetail_Environment_SourceSystem")]
    protected TargetSystem_Environment _SourceSystem;

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

    public PackageInquiryDetail_Environment PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Environment) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public TargetSystem_Environment SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Environment) this.PropertyGet(nameof (SourceSystem));
      }
    }
  }
}
