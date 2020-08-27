// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDefect_Info
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
  public class ContainerDefect_Info : Defect_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefect_Info_ServiceDetails")]
    protected ContainerDefectDetail_Info _ServiceDetails;

    public ContainerDefectDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ContainerDefectDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
