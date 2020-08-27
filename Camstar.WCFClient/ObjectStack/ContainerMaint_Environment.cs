// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaint_Environment
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
  public class ContainerMaint_Environment : ChgContainerAttribute_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaint_Environment_ServiceDetail")]
    [Metadata("Provides a service that allows changing the value of all container, container detail and current status attributes allowed to be updated.", "ContainerMaintDetail", false, false, false, "ContainerMaintDetail", 1050606, true, false, false, null)]
    protected ContainerMaintDetail_Environment _ServiceDetail;

    public ContainerMaintDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (ContainerMaintDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
