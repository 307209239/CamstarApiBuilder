// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDefect_Environment
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
  public class ContainerDefect_Environment : Defect_Environment
  {
    [Metadata("ContainerDefect transaction detail.", "ContainerDefectDetail", false, true, false, "ContainerDefectDetail", 1049639, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefect_Environment_ServiceDetails")]
    protected ContainerDefectDetail_Environment _ServiceDetails;

    public ContainerDefectDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ContainerDefectDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
