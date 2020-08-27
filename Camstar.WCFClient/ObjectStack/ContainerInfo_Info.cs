// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfo_Info
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
  public class ContainerInfo_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_Info_CurrentStatus")]
    protected CurrentStatus_Info _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_Info_Container")]
    protected Container_Info _Container;

    public CurrentStatus_Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus_Info) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Container_Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container_Info) this.PropertyGet(nameof (Container));
      }
    }
  }
}
