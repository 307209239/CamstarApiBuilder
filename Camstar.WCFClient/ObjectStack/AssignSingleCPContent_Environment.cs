// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContent_Environment
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
  public class AssignSingleCPContent_Environment : AssignChangePkgContent_Environment
  {
    [Metadata("Detail for package content for a change package.", "AssignSingleCPContentDtl", false, false, false, "AssignSingleCPContentDtl", 1051158, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContent_Environment_ServiceDetail")]
    protected AssignSingleCPContentDtl_Environment _ServiceDetail;

    public AssignSingleCPContentDtl_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignSingleCPContentDtl_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
