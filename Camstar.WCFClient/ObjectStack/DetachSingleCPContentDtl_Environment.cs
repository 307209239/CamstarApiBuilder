// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachSingleCPContentDtl_Environment
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
  public class DetachSingleCPContentDtl_Environment : AssignChangePkgContentDtl_Environment
  {
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_Environment_ChangePackages")]
    protected Environment _ChangePackages;
    [Metadata("Detach content/modeling instance to a ChangePackage.", "DetachSingleCPContent", false, false, false, "DetachSingleCPContent", 16778053, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_Environment_DetachSingleCPContent")]
    protected DetachSingleCPContent_Environment _DetachSingleCPContent;

    public Environment ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackages));
      }
    }

    public DetachSingleCPContent_Environment DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent_Environment) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }
  }
}
