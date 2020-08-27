// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachSingleCPContent_Environment
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
  public class DetachSingleCPContent_Environment : AssignChangePkgContent_Environment
  {
    [Metadata("Detail for package content for a change package.", "DetachSingleCPContentDtl", false, false, false, "DetachSingleCPContentDtl", 1051158, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContent_Environment_ServiceDetail")]
    protected DetachSingleCPContentDtl_Environment _ServiceDetail;

    public DetachSingleCPContentDtl_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (DetachSingleCPContentDtl_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
